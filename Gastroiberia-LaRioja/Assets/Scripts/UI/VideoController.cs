using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button[] buttonsToShow;
    public GameObject Video;
    public GameObject skip;

    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    private void OnVideoEnded(VideoPlayer vp)
    {

        // Show the buttons
        foreach (Button button in buttonsToShow)
        {
            Destroy(skip);
            Destroy(Video);
            button.gameObject.SetActive(true);
        }
    }
}
