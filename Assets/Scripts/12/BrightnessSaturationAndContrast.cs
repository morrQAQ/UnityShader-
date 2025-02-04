using UnityEngine;

public class BrightnessSaturationAndContrast : PostEffectsBase
{
    public BrightnessSaturationAndContrastSettings settings;

    protected override void ApplySettings(RenderTexture src, RenderTexture dest)
    {
        Material.SetFloat("_Brightness", settings.brightness);
        Material.SetFloat("_Saturation", settings.saturation);
        Material.SetFloat("_Contrast", settings.contrast);

        Graphics.Blit(src, dest, Material);
    }
}

[System.Serializable]
public class BrightnessSaturationAndContrastSettings
{
    [Range(0.0f, 3.0f)]
    public float brightness = 1.0f;

    [Range(0.0f, 3.0f)]
    public float saturation = 1.0f;

    [Range(0.0f, 3.0f)]
    public float contrast = 1.0f;
}
