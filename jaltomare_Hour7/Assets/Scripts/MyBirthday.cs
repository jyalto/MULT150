using System.Collections;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{

    void Start()
    {

        for (int month = 1; month <= 12; month++)
        {
            if (month == 3)
            {
                Debug.Log("It's My Birthday!");
            }
            else
            {
                Debug.Log(month);
            }
        }

        for (int day = 1; day <= 31; day++)
        {
            if (day == 28)
            {
                Debug.Log("It's My Birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }
}
