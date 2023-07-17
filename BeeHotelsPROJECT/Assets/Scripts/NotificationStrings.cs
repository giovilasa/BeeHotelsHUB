using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NotificationStrings", menuName = "Notification System/Notification Strings")]
public class NotificationStrings : ScriptableObject
{
    public string[] managerNames;
    public string[] hotelNames;
    public string[] hazardNames;
    public string[] equippedReinforcements;
    public string[] equippedActivities;

    public string GetRandomManagerName()
    {
        if (managerNames.Length > 0)
        {
            int randomIndex = Random.Range(0, managerNames.Length);
            return managerNames[randomIndex];
        }

        return string.Empty;
    }

    public string GetRandomHotelName()
    {
        if (hotelNames.Length > 0)
        {
            int randomIndex = Random.Range(0, hotelNames.Length);
            return hotelNames[randomIndex];
        }

        return string.Empty;
    }

    public string GetRandomHazardName()
    {
        if (hazardNames.Length > 0)
        {
            int randomIndex = Random.Range(0, hazardNames.Length);
            return hazardNames[randomIndex];
        }

        return string.Empty;
    }

    public string GetRandomEquippedReinforcement()
    {
        if (equippedReinforcements.Length > 0)
        {
            int randomIndex = Random.Range(0, equippedReinforcements.Length);
            return equippedReinforcements[randomIndex];
        }

        return string.Empty;
    }

    public string GetRandomEquippedActivity()
    {
        if (equippedActivities.Length > 0)
        {
            int randomIndex = Random.Range(0, equippedActivities.Length);
            return equippedActivities[randomIndex];
        }

        return string.Empty;
    }
}
