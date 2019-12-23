using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectButtonController : MonoBehaviour
{
    public Button m_PlayButton;
    void Start()
    {
        m_PlayButton.enabled = true;
        m_PlayButton.GetComponent<Image>().enabled = true;
    }
}
