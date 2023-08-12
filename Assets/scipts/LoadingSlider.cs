using UnityEngine;
using UnityEngine.UI;

public class LoadingSlider : MonoBehaviour
{
    public Slider slider;
    private float loadingSpeed;
    private float maxValue = 100f;
    private float currentValue = 0f;

    public GameObject homescreen;
    public GameObject loadscreen;
    bool sl = false;
    int wait;
    private void Start()
    {
        loadscreen.SetActive(true);
        homescreen.SetActive(false);
       
        Invoke(nameof(StartLoading), 2f);
        Invoke(nameof(StopLoading), 4f);

    }
    private void Update()
    {
        wait = Random.Range(1, 4);
        Invoke(nameof(load), wait);
    }

    void load()
    {
        if (currentValue <= maxValue && sl == true)
        {
            loadingSpeed = Random.Range(1, 5);
            currentValue += loadingSpeed* Time.deltaTime;
            slider.value = currentValue;
            // Debug.Log("-->" + currentValue);
        }
        if (currentValue >= maxValue)
        {
            homescreen.SetActive(true);
            loadscreen.SetActive(false);

        }
    }

    // Call this method when you want to start the loading animation
    public void StartLoading()
    {
        sl = true;
        currentValue = 0f;
        slider.value = 0f;
    }

    // Call this method when you want to stop the loading animation
    public void StopLoading()
    {
        currentValue = maxValue;
        slider.value = maxValue;
    }
}
