using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    private Transform m_HourPivot, m_MinutePivot, m_SecondPivot;

    private const float m_HoursToDegrees = 30f, m_MinutesToDegrees = 6f, m_SecondsToDegrees = 6f;

    private TimeSpan m_Time;


    void Awake()         
    {
        m_Time = DateTime.Now.TimeOfDay;
    }

    void Update() 
    {

        m_Time = DateTime.Now.TimeOfDay;
        Debug.Log(m_Time);

        m_HourPivot.localRotation = Quaternion.Euler(0f, 0f, m_HoursToDegrees *  (float)m_Time.TotalHours);
        m_MinutePivot.localRotation = Quaternion.Euler(0f, 0f, m_MinutesToDegrees * (float)m_Time.TotalMinutes);
        m_SecondPivot.localRotation = Quaternion.Euler(0f, 0f, m_SecondsToDegrees * (float)m_Time.TotalSeconds);


    }






}
