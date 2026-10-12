using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    [Header("--- 音訊播放器 ---")]
    [SerializeField] private AudioSource audioSource; // 負責播放單次音效（點擊、停止）
    [SerializeField] private AudioSource loopAudioSource; // 負責循環播放（轉盤中）

    [Header("--- 音效檔案 (Audio Clip) ---")]
    [SerializeField] private AudioClip clickClip;   // 點擊音效
    [SerializeField] private AudioClip rotateClip;  // 轉盤中音效（循環）
    [SerializeField] private AudioClip stopClip;    // 停止音效

    private bool isRotating = false; // 用來記錄目前轉盤是不是在旋轉

    void Start()
    {
        // 影格速度設為 60 FPS
        Application.targetFrameRate = 60;

        // 設定轉盤中音效為循環播放
        if (loopAudioSource != null)
        {
            loopAudioSource.loop = true;
            loopAudioSource.clip = rotateClip;
        }
    }

    void Update()
    {
        // 1. 點擊滑鼠：開始旋轉
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
            isRotating = true;

            // 播放點擊音效
            PlaySound(clickClip);

            // 開始播放轉盤中的循環音效
            if (loopAudioSource != null && rotateClip != null && !loopAudioSource.isPlaying)
            {
                loopAudioSource.Play();
            }
        }

        // 讓物件旋轉
        transform.Rotate(0, 0, this.rotSpeed);

        // 每次旋轉的速度都會慢慢減少
        this.rotSpeed *= 0.994f;

        // 2. 判斷轉盤何時停止
        // 當速度小於 0.01 且之前還判定在旋轉時，視為「剛好停止」
        if (isRotating && this.rotSpeed < 0.01f)
        {
            this.rotSpeed = 0; // 完全靜止
            isRotating = false; // 標記為已停止

            // 停止轉盤中的循環音效
            if (loopAudioSource != null)
            {
                loopAudioSource.Stop();
            }

            // 播放停止音效
            PlaySound(stopClip);
        }
    }

    // 播放單次音效的輔助方法
    void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
