using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("UI")]
    public Image image;
    public Text countText;
    public string Methodname = "Action1";

    [HideInInspector] public Item item;
    [HideInInspector] public int count = 1;
    [HideInInspector] public Transform parentAfterDrag;


    [Header("Random Right-Click Actions")]
    [Tooltip("Assign any scripts with a public void RunAction() method or UnityEvents here.")]
    public MonoBehaviour[] randomScripts; // Assign random scripts in Inspector


    private void Start()
    {
        InitalizeItem(item);
    }


    public void InitalizeItem(Item newItem)
    {
        item = newItem;
        image.sprite = newItem.image;
        RefreshCount();
    }


    public void RefreshCount()
    {
        countText.text = count.ToString();
        bool textActive = count > 1;
        countText.gameObject.SetActive(textActive);
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
    }


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        image.raycastTarget = true;
        transform.SetParent(parentAfterDrag);
    }


    private void Update()
    {
        // Detect right-click on this item (only if mouse is over it)
        if (IsPointerOverUIElement() && Input.GetMouseButtonDown(1))
        {
            RunRandomScript();
        }
    }


    private void RunRandomScript()
    {
        if (randomScripts != null && randomScripts.Length > 0)
        {
            int index = Random.Range(0, randomScripts.Length);
            MonoBehaviour randomScript = randomScripts[index];


            // Look for a method called "RunAction" on the script and call it
            var method = randomScript.GetType().GetMethod(Methodname);
            if (method != null)
            {
                method.Invoke(randomScript, null);
            }
            else
            {
                Debug.LogWarning($"{randomScript.name} does not have a {Methodname} method!");
            }
        }
    }


    // Utility function to check if pointer is over this UI element
    private bool IsPointerOverUIElement()
    {
        return EventSystem.current.IsPointerOverGameObject() &&
               RectTransformUtility.RectangleContainsScreenPoint(
                   GetComponent<RectTransform>(),
                   Input.mousePosition,
                   null
               );
    }
}
