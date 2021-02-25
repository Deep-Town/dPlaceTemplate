using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dPlaceSettings : MonoBehaviour
{
    public bool fog;
    public Color fogColor;
    public Material skybox;
    public FogMode fogMode;
    public int fogStart;
    public int fogEnd;

    // Start is called before the first frame update
    void Start()
    {
        if (fog)
        {
            RenderSettings.fog = fog;
            RenderSettings.fogColor = fogColor;
            RenderSettings.fogMode = fogMode;
            RenderSettings.fogStartDistance = fogStart;
            RenderSettings.fogEndDistance = fogEnd;
        }
        if(skybox != null)
        {
            RenderSettings.skybox = skybox;
        }
        else
        {
            RenderSettings.skybox = null;
            //RenderSettings.ambientLight = new Color(255, 255, 255, 100);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
