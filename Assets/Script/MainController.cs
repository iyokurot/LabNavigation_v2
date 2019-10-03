using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MainController : MonoBehaviour{
    [SerializeField]
    GameObject demoMovie;
    string videoUrl="file://C:/Users/03yuk/Desktop/製作物提出用/PromotionImage.mp4";
    // Start is called before the first frame update
    void Start()
    {
        demoMovie.GetComponent<VideoPlayer>().url=videoUrl;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
