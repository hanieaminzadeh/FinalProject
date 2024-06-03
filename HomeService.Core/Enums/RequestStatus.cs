using System.ComponentModel.DataAnnotations;

namespace HomeService.Core.Enums;

public enum RequestStatus
{
    [Display(Name = "سفارش شما ثبت شد")]
    Registered = 1,
    [Display(Name = "سفارش ثبت شده است و مشتری در حال ارزیابی پیشنهاد متخصصین است")]
    CheckingAndWaitingExpert = 2,
    [Display(Name = "سفارش شما توسط متخصص تایید شد")]
    RegisteredByExpert = 3,
    [Display(Name = "انجام شد")]
    Done = 4,
}