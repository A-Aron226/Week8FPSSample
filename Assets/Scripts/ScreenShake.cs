using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
public class ScreenShake : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vcam;
    public float targetTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetTime += Time.deltaTime; //for the EndShake method. Alternate solution
        if (targetTime > 0.8f)
        {
            EndShake();
            targetTime = 0;
        }
    }

    [ContextMenu("Start Shake")] //Testing purposes

    public void StartShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 2;
        

    }

    [ContextMenu("End Shake")] //Testing purposes

    public void EndShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
    }
}
