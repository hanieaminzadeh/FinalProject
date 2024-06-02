using HomeService.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Framework;

public static class EnumExtensionMethods
{
    public static string GetEnumDisplayName(this Enum enumType)
    {
        return enumType.GetType().GetMember(enumType.ToString()).First()
                       .GetCustomAttribute<DisplayAttribute>().Name;
    }

    public static string GetEnumColor(this RequestStatus status)
    {
        string color;
        switch (status)
        {
            case RequestStatus.Registered:
                color = "blue";
                break;
            case RequestStatus.Cancelled:
                color = "red";
                break;
            case RequestStatus.CheckingAndWaitingExpert:
                color = "green";
                break;
            case RequestStatus.Started:
                color = "purple";
                break;
            case RequestStatus.Paid:
                color = "orange";
                break;
            case RequestStatus.RegisteredByExpert:
                color = "red";
                break;
            case RequestStatus.ExpertComingToYourHome:
                color = "brown";
                break;
            default:
                color = "black";
                break;
        }
        return color;
    }
}