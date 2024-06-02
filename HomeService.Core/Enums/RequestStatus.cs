using System.ComponentModel.DataAnnotations;

namespace HomeService.Core.Enums;

public enum RequestStatus
{
    [Display(Name = "سفارش شما ثبت شد")]
    Registered = 1,
    [Display(Name = "سفارش شما لغو شد")]
    Cancelled = 2,
    [Display(Name = "سفارش در حال بررسی و تایید متخصصین")]
    CheckingAndWaitingExpert = 3,
    [Display(Name = "متخصصین در حال انجام کار")]
    Started = 4,
    [Display(Name = "هزینه سفارش شما پرداخت شد")]
    Paid = 5,
    [Display(Name = "سفارش شما توسط متخصص تایید شد")]
    RegisteredByExpert = 6,
    [Display(Name = "متخصص در حال امدن به منزل شما میباشد")]
    ExpertComingToYourHome = 7,
    [Display(Name = "انجام شد")]
    Done = 7,
}
