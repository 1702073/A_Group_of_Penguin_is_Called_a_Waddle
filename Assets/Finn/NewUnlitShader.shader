Shader "Custom/URP_2D_BlacklightGlow"
{
    Properties
    {
        _MainTex ("Sprite Texture", 2D) = "white" {}
        _TintColor ("Tint Color", Color) = (1, 1, 1, 1)
        _GlowColor ("Glow Color", Color) = (1, 0, 1, 1)
        _GlowIntensity ("Glow Intensity", Float) = 3
    }


    SubShader
    {
        Tags{
            "RenderType"="Transparent"
            "Queue"="Transparent"
            "IgnoreProjector"="True"
            "CanUseSpriteAtlas"="True"
        }


        Blend SrcAlpha OneMinusSrcAlpha
        Cull Off
        ZWrite Off


        Pass
        {
            Name "Blacklight_2D"
            Tags { "LightMode"="Universal2D" }


            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"


            struct Attributes
            {
                float4 positionOS : POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };


            struct Varyings
            {
                float4 positionHCS : SV_POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };


            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _TintColor;
            float4 _GlowColor;
            float _GlowIntensity;


            Varyings vert (Attributes IN)
            {
                Varyings OUT;
                OUT.positionHCS = TransformObjectToHClip(IN.positionOS.xyz);
                OUT.uv = TRANSFORM_TEX(IN.uv, _MainTex);
                OUT.color = IN.color * _TintColor;
                return OUT;
            }


            float4 frag (Varyings IN) : SV_Target
            {
                float4 baseColor = tex2D(_MainTex, IN.uv) * IN.color;


                // Emission (fake blacklight glow)
                float4 glow = _GlowColor * _GlowIntensity;


                float4 finalColor = baseColor + glow;


                return finalColor;
            }
            ENDHLSL
        }
    }


    FallBack "Sprites/Default"
}
