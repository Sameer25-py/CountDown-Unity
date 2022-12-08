using System;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    private long   _finalTime; 
    private long remainingTime;
    private float  _elapsedTime;
    private string _currentTime;
    public  string GetCurrentTimeString => _currentTime;
    public  bool   IsInProgress         => remainingTime > 0;
    
/// <summary>
///
///
/// </summary>
/// <param name="finalTime"></param>
    public void SetTargetTime(long finalTime)
    {
        _finalTime    = finalTime;
    }
    
    private void Update()
    {
        if (!IsInProgress) return;
        _elapsedTime += Time.deltaTime;
        if (!(_elapsedTime > 1f)) return;
        _elapsedTime  = 0f;
        remainingTime = Math.Max(0,_finalTime - DateTimeOffset.Now.ToUnixTimeSeconds());
        var dateTime = DateTimeOffset.FromUnixTimeSeconds(remainingTime).UtcDateTime;
        _currentTime = $"{dateTime.Hour:00} : {dateTime.Minute:00} : {dateTime.Second:00}";
    }
}
