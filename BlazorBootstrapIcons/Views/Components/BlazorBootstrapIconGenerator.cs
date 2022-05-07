using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorBootstrapIcons.Views.Components.Icons;

public abstract class BaseIcon : ComponentBase
{
    [Parameter]
    public int Size { get; set; } = 24;

    protected abstract string IconSource { get; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(sequence: 1, elementName: "img");
        builder.AddAttribute(sequence: 2, name: "src", value: $"bootstrap-icons/{IconSource}.svg");
        builder.AddAttribute(sequence: 3, name: "width", value: Size);
        builder.AddAttribute(sequence: 4, name: "height", value: Size);
        builder.AddAttribute(sequence: 5, name: "loading", value: "lazy");
        builder.CloseElement();
    }
}

public class OneTwoThreeIcon : BaseIcon
{
    protected override string IconSource => "123";
}

public class AlarmFillIcon : BaseIcon
{
    protected override string IconSource => "alarm-fill";
}

public class AlarmIcon : BaseIcon
{
    protected override string IconSource => "alarm";
}

public class AlignBottomIcon : BaseIcon
{
    protected override string IconSource => "align-bottom";
}

public class AlignCenterIcon : BaseIcon
{
    protected override string IconSource => "align-center";
}

public class AlignEndIcon : BaseIcon
{
    protected override string IconSource => "align-end";
}

public class AlignMiddleIcon : BaseIcon
{
    protected override string IconSource => "align-middle";
}

public class AlignStartIcon : BaseIcon
{
    protected override string IconSource => "align-start";
}

public class AlignTopIcon : BaseIcon
{
    protected override string IconSource => "align-top";
}

public class AltIcon : BaseIcon
{
    protected override string IconSource => "alt";
}

public class AppIndicatorIcon : BaseIcon
{
    protected override string IconSource => "app-indicator";
}

public class AppIcon : BaseIcon
{
    protected override string IconSource => "app";
}

public class ArchiveFillIcon : BaseIcon
{
    protected override string IconSource => "archive-fill";
}

public class ArchiveIcon : BaseIcon
{
    protected override string IconSource => "archive";
}

public class Arrow90degDownIcon : BaseIcon
{
    protected override string IconSource => "arrow-90deg-down";
}

public class Arrow90degLeftIcon : BaseIcon
{
    protected override string IconSource => "arrow-90deg-left";
}

public class Arrow90degRightIcon : BaseIcon
{
    protected override string IconSource => "arrow-90deg-right";
}

public class Arrow90degUpIcon : BaseIcon
{
    protected override string IconSource => "arrow-90deg-up";
}

public class ArrowBarDownIcon : BaseIcon
{
    protected override string IconSource => "arrow-bar-down";
}

public class ArrowBarLeftIcon : BaseIcon
{
    protected override string IconSource => "arrow-bar-left";
}

public class ArrowBarRightIcon : BaseIcon
{
    protected override string IconSource => "arrow-bar-right";
}

public class ArrowBarUpIcon : BaseIcon
{
    protected override string IconSource => "arrow-bar-up";
}

public class ArrowClockwiseIcon : BaseIcon
{
    protected override string IconSource => "arrow-clockwise";
}

public class ArrowCounterclockwiseIcon : BaseIcon
{
    protected override string IconSource => "arrow-counterclockwise";
}

public class ArrowDownCircleFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-circle-fill";
}

public class ArrowDownCircleIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-circle";
}

public class ArrowDownLeftCircleFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-left-circle-fill";
}

public class ArrowDownLeftCircleIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-left-circle";
}

public class ArrowDownLeftSquareFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-left-square-fill";
}

public class ArrowDownLeftSquareIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-left-square";
}

public class ArrowDownLeftIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-left";
}

public class ArrowDownRightCircleFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-right-circle-fill";
}

public class ArrowDownRightCircleIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-right-circle";
}

public class ArrowDownRightSquareFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-right-square-fill";
}

public class ArrowDownRightSquareIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-right-square";
}

public class ArrowDownRightIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-right";
}

public class ArrowDownShortIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-short";
}

public class ArrowDownSquareFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-square-fill";
}

public class ArrowDownSquareIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-square";
}

public class ArrowDownUpIcon : BaseIcon
{
    protected override string IconSource => "arrow-down-up";
}

public class ArrowDownIcon : BaseIcon
{
    protected override string IconSource => "arrow-down";
}

public class ArrowLeftCircleFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-left-circle-fill";
}

public class ArrowLeftCircleIcon : BaseIcon
{
    protected override string IconSource => "arrow-left-circle";
}

public class ArrowLeftRightIcon : BaseIcon
{
    protected override string IconSource => "arrow-left-right";
}

public class ArrowLeftShortIcon : BaseIcon
{
    protected override string IconSource => "arrow-left-short";
}

public class ArrowLeftSquareFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-left-square-fill";
}

public class ArrowLeftSquareIcon : BaseIcon
{
    protected override string IconSource => "arrow-left-square";
}

public class ArrowLeftIcon : BaseIcon
{
    protected override string IconSource => "arrow-left";
}

public class ArrowRepeatIcon : BaseIcon
{
    protected override string IconSource => "arrow-repeat";
}

public class ArrowReturnLeftIcon : BaseIcon
{
    protected override string IconSource => "arrow-return-left";
}

public class ArrowReturnRightIcon : BaseIcon
{
    protected override string IconSource => "arrow-return-right";
}

public class ArrowRightCircleFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-right-circle-fill";
}

public class ArrowRightCircleIcon : BaseIcon
{
    protected override string IconSource => "arrow-right-circle";
}

public class ArrowRightShortIcon : BaseIcon
{
    protected override string IconSource => "arrow-right-short";
}

public class ArrowRightSquareFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-right-square-fill";
}

public class ArrowRightSquareIcon : BaseIcon
{
    protected override string IconSource => "arrow-right-square";
}

public class ArrowRightIcon : BaseIcon
{
    protected override string IconSource => "arrow-right";
}

public class ArrowUpCircleFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-circle-fill";
}

public class ArrowUpCircleIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-circle";
}

public class ArrowUpLeftCircleFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-left-circle-fill";
}

public class ArrowUpLeftCircleIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-left-circle";
}

public class ArrowUpLeftSquareFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-left-square-fill";
}

public class ArrowUpLeftSquareIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-left-square";
}

public class ArrowUpLeftIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-left";
}

public class ArrowUpRightCircleFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-right-circle-fill";
}

public class ArrowUpRightCircleIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-right-circle";
}

public class ArrowUpRightSquareFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-right-square-fill";
}

public class ArrowUpRightSquareIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-right-square";
}

public class ArrowUpRightIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-right";
}

public class ArrowUpShortIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-short";
}

public class ArrowUpSquareFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-square-fill";
}

public class ArrowUpSquareIcon : BaseIcon
{
    protected override string IconSource => "arrow-up-square";
}

public class ArrowUpIcon : BaseIcon
{
    protected override string IconSource => "arrow-up";
}

public class ArrowsAngleContractIcon : BaseIcon
{
    protected override string IconSource => "arrows-angle-contract";
}

public class ArrowsAngleExpandIcon : BaseIcon
{
    protected override string IconSource => "arrows-angle-expand";
}

public class ArrowsCollapseIcon : BaseIcon
{
    protected override string IconSource => "arrows-collapse";
}

public class ArrowsExpandIcon : BaseIcon
{
    protected override string IconSource => "arrows-expand";
}

public class ArrowsFullscreenIcon : BaseIcon
{
    protected override string IconSource => "arrows-fullscreen";
}

public class ArrowsMoveIcon : BaseIcon
{
    protected override string IconSource => "arrows-move";
}

public class AspectRatioFillIcon : BaseIcon
{
    protected override string IconSource => "aspect-ratio-fill";
}

public class AspectRatioIcon : BaseIcon
{
    protected override string IconSource => "aspect-ratio";
}

public class AsteriskIcon : BaseIcon
{
    protected override string IconSource => "asterisk";
}

public class AtIcon : BaseIcon
{
    protected override string IconSource => "at";
}

public class AwardFillIcon : BaseIcon
{
    protected override string IconSource => "award-fill";
}

public class AwardIcon : BaseIcon
{
    protected override string IconSource => "award";
}

public class BackIcon : BaseIcon
{
    protected override string IconSource => "back";
}

public class BackspaceFillIcon : BaseIcon
{
    protected override string IconSource => "backspace-fill";
}

public class BackspaceReverseFillIcon : BaseIcon
{
    protected override string IconSource => "backspace-reverse-fill";
}

public class BackspaceReverseIcon : BaseIcon
{
    protected override string IconSource => "backspace-reverse";
}

public class BackspaceIcon : BaseIcon
{
    protected override string IconSource => "backspace";
}

public class Badge3dFillIcon : BaseIcon
{
    protected override string IconSource => "badge-3d-fill";
}

public class Badge3dIcon : BaseIcon
{
    protected override string IconSource => "badge-3d";
}

public class Badge4kFillIcon : BaseIcon
{
    protected override string IconSource => "badge-4k-fill";
}

public class Badge4kIcon : BaseIcon
{
    protected override string IconSource => "badge-4k";
}

public class Badge8kFillIcon : BaseIcon
{
    protected override string IconSource => "badge-8k-fill";
}

public class Badge8kIcon : BaseIcon
{
    protected override string IconSource => "badge-8k";
}

public class BadgeAdFillIcon : BaseIcon
{
    protected override string IconSource => "badge-ad-fill";
}

public class BadgeAdIcon : BaseIcon
{
    protected override string IconSource => "badge-ad";
}

public class BadgeArFillIcon : BaseIcon
{
    protected override string IconSource => "badge-ar-fill";
}

public class BadgeArIcon : BaseIcon
{
    protected override string IconSource => "badge-ar";
}

public class BadgeCcFillIcon : BaseIcon
{
    protected override string IconSource => "badge-cc-fill";
}

public class BadgeCcIcon : BaseIcon
{
    protected override string IconSource => "badge-cc";
}

public class BadgeHdFillIcon : BaseIcon
{
    protected override string IconSource => "badge-hd-fill";
}

public class BadgeHdIcon : BaseIcon
{
    protected override string IconSource => "badge-hd";
}

public class BadgeTmFillIcon : BaseIcon
{
    protected override string IconSource => "badge-tm-fill";
}

public class BadgeTmIcon : BaseIcon
{
    protected override string IconSource => "badge-tm";
}

public class BadgeVoFillIcon : BaseIcon
{
    protected override string IconSource => "badge-vo-fill";
}

public class BadgeVoIcon : BaseIcon
{
    protected override string IconSource => "badge-vo";
}

public class BadgeVrFillIcon : BaseIcon
{
    protected override string IconSource => "badge-vr-fill";
}

public class BadgeVrIcon : BaseIcon
{
    protected override string IconSource => "badge-vr";
}

public class BadgeWcFillIcon : BaseIcon
{
    protected override string IconSource => "badge-wc-fill";
}

public class BadgeWcIcon : BaseIcon
{
    protected override string IconSource => "badge-wc";
}

public class BagCheckFillIcon : BaseIcon
{
    protected override string IconSource => "bag-check-fill";
}

public class BagCheckIcon : BaseIcon
{
    protected override string IconSource => "bag-check";
}

public class BagDashFillIcon : BaseIcon
{
    protected override string IconSource => "bag-dash-fill";
}

public class BagDashIcon : BaseIcon
{
    protected override string IconSource => "bag-dash";
}

public class BagFillIcon : BaseIcon
{
    protected override string IconSource => "bag-fill";
}

public class BagPlusFillIcon : BaseIcon
{
    protected override string IconSource => "bag-plus-fill";
}

public class BagPlusIcon : BaseIcon
{
    protected override string IconSource => "bag-plus";
}

public class BagXFillIcon : BaseIcon
{
    protected override string IconSource => "bag-x-fill";
}

public class BagXIcon : BaseIcon
{
    protected override string IconSource => "bag-x";
}

public class BagIcon : BaseIcon
{
    protected override string IconSource => "bag";
}

public class BarChartFillIcon : BaseIcon
{
    protected override string IconSource => "bar-chart-fill";
}

public class BarChartLineFillIcon : BaseIcon
{
    protected override string IconSource => "bar-chart-line-fill";
}

public class BarChartLineIcon : BaseIcon
{
    protected override string IconSource => "bar-chart-line";
}

public class BarChartStepsIcon : BaseIcon
{
    protected override string IconSource => "bar-chart-steps";
}

public class BarChartIcon : BaseIcon
{
    protected override string IconSource => "bar-chart";
}

public class BasketFillIcon : BaseIcon
{
    protected override string IconSource => "basket-fill";
}

public class BasketIcon : BaseIcon
{
    protected override string IconSource => "basket";
}

public class Basket2FillIcon : BaseIcon
{
    protected override string IconSource => "basket2-fill";
}

public class Basket2Icon : BaseIcon
{
    protected override string IconSource => "basket2";
}

public class Basket3FillIcon : BaseIcon
{
    protected override string IconSource => "basket3-fill";
}

public class Basket3Icon : BaseIcon
{
    protected override string IconSource => "basket3";
}

public class BatteryChargingIcon : BaseIcon
{
    protected override string IconSource => "battery-charging";
}

public class BatteryFullIcon : BaseIcon
{
    protected override string IconSource => "battery-full";
}

public class BatteryHalfIcon : BaseIcon
{
    protected override string IconSource => "battery-half";
}

public class BatteryIcon : BaseIcon
{
    protected override string IconSource => "battery";
}

public class BellFillIcon : BaseIcon
{
    protected override string IconSource => "bell-fill";
}

public class BellIcon : BaseIcon
{
    protected override string IconSource => "bell";
}

public class BezierIcon : BaseIcon
{
    protected override string IconSource => "bezier";
}

public class Bezier2Icon : BaseIcon
{
    protected override string IconSource => "bezier2";
}

public class BicycleIcon : BaseIcon
{
    protected override string IconSource => "bicycle";
}

public class BinocularsFillIcon : BaseIcon
{
    protected override string IconSource => "binoculars-fill";
}

public class BinocularsIcon : BaseIcon
{
    protected override string IconSource => "binoculars";
}

public class BlockquoteLeftIcon : BaseIcon
{
    protected override string IconSource => "blockquote-left";
}

public class BlockquoteRightIcon : BaseIcon
{
    protected override string IconSource => "blockquote-right";
}

public class BookFillIcon : BaseIcon
{
    protected override string IconSource => "book-fill";
}

public class BookHalfIcon : BaseIcon
{
    protected override string IconSource => "book-half";
}

public class BookIcon : BaseIcon
{
    protected override string IconSource => "book";
}

public class BookmarkCheckFillIcon : BaseIcon
{
    protected override string IconSource => "bookmark-check-fill";
}

public class BookmarkCheckIcon : BaseIcon
{
    protected override string IconSource => "bookmark-check";
}

public class BookmarkDashFillIcon : BaseIcon
{
    protected override string IconSource => "bookmark-dash-fill";
}

public class BookmarkDashIcon : BaseIcon
{
    protected override string IconSource => "bookmark-dash";
}

public class BookmarkFillIcon : BaseIcon
{
    protected override string IconSource => "bookmark-fill";
}

public class BookmarkHeartFillIcon : BaseIcon
{
    protected override string IconSource => "bookmark-heart-fill";
}

public class BookmarkHeartIcon : BaseIcon
{
    protected override string IconSource => "bookmark-heart";
}

public class BookmarkPlusFillIcon : BaseIcon
{
    protected override string IconSource => "bookmark-plus-fill";
}

public class BookmarkPlusIcon : BaseIcon
{
    protected override string IconSource => "bookmark-plus";
}

public class BookmarkStarFillIcon : BaseIcon
{
    protected override string IconSource => "bookmark-star-fill";
}

public class BookmarkStarIcon : BaseIcon
{
    protected override string IconSource => "bookmark-star";
}

public class BookmarkXFillIcon : BaseIcon
{
    protected override string IconSource => "bookmark-x-fill";
}

public class BookmarkXIcon : BaseIcon
{
    protected override string IconSource => "bookmark-x";
}

public class BookmarkIcon : BaseIcon
{
    protected override string IconSource => "bookmark";
}

public class BookmarksFillIcon : BaseIcon
{
    protected override string IconSource => "bookmarks-fill";
}

public class BookmarksIcon : BaseIcon
{
    protected override string IconSource => "bookmarks";
}

public class BookshelfIcon : BaseIcon
{
    protected override string IconSource => "bookshelf";
}

public class BootstrapFillIcon : BaseIcon
{
    protected override string IconSource => "bootstrap-fill";
}

public class BootstrapRebootIcon : BaseIcon
{
    protected override string IconSource => "bootstrap-reboot";
}

public class BootstrapIcon : BaseIcon
{
    protected override string IconSource => "bootstrap";
}

public class BorderAllIcon : BaseIcon
{
    protected override string IconSource => "border-all";
}

public class BorderBottomIcon : BaseIcon
{
    protected override string IconSource => "border-bottom";
}

public class BorderCenterIcon : BaseIcon
{
    protected override string IconSource => "border-center";
}

public class BorderInnerIcon : BaseIcon
{
    protected override string IconSource => "border-inner";
}

public class BorderLeftIcon : BaseIcon
{
    protected override string IconSource => "border-left";
}

public class BorderMiddleIcon : BaseIcon
{
    protected override string IconSource => "border-middle";
}

public class BorderOuterIcon : BaseIcon
{
    protected override string IconSource => "border-outer";
}

public class BorderRightIcon : BaseIcon
{
    protected override string IconSource => "border-right";
}

public class BorderStyleIcon : BaseIcon
{
    protected override string IconSource => "border-style";
}

public class BorderTopIcon : BaseIcon
{
    protected override string IconSource => "border-top";
}

public class BorderWidthIcon : BaseIcon
{
    protected override string IconSource => "border-width";
}

public class BorderIcon : BaseIcon
{
    protected override string IconSource => "border";
}

public class BoundingBoxCirclesIcon : BaseIcon
{
    protected override string IconSource => "bounding-box-circles";
}

public class BoundingBoxIcon : BaseIcon
{
    protected override string IconSource => "bounding-box";
}

public class BoxArrowDownLeftIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-down-left";
}

public class BoxArrowDownRightIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-down-right";
}

public class BoxArrowDownIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-down";
}

public class BoxArrowInDownLeftIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-in-down-left";
}

public class BoxArrowInDownRightIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-in-down-right";
}

public class BoxArrowInDownIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-in-down";
}

public class BoxArrowInLeftIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-in-left";
}

public class BoxArrowInRightIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-in-right";
}

public class BoxArrowInUpLeftIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-in-up-left";
}

public class BoxArrowInUpRightIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-in-up-right";
}

public class BoxArrowInUpIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-in-up";
}

public class BoxArrowLeftIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-left";
}

public class BoxArrowRightIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-right";
}

public class BoxArrowUpLeftIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-up-left";
}

public class BoxArrowUpRightIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-up-right";
}

public class BoxArrowUpIcon : BaseIcon
{
    protected override string IconSource => "box-arrow-up";
}

public class BoxSeamIcon : BaseIcon
{
    protected override string IconSource => "box-seam";
}

public class BoxIcon : BaseIcon
{
    protected override string IconSource => "box";
}

public class BracesIcon : BaseIcon
{
    protected override string IconSource => "braces";
}

public class BricksIcon : BaseIcon
{
    protected override string IconSource => "bricks";
}

public class BriefcaseFillIcon : BaseIcon
{
    protected override string IconSource => "briefcase-fill";
}

public class BriefcaseIcon : BaseIcon
{
    protected override string IconSource => "briefcase";
}

public class BrightnessAltHighFillIcon : BaseIcon
{
    protected override string IconSource => "brightness-alt-high-fill";
}

public class BrightnessAltHighIcon : BaseIcon
{
    protected override string IconSource => "brightness-alt-high";
}

public class BrightnessAltLowFillIcon : BaseIcon
{
    protected override string IconSource => "brightness-alt-low-fill";
}

public class BrightnessAltLowIcon : BaseIcon
{
    protected override string IconSource => "brightness-alt-low";
}

public class BrightnessHighFillIcon : BaseIcon
{
    protected override string IconSource => "brightness-high-fill";
}

public class BrightnessHighIcon : BaseIcon
{
    protected override string IconSource => "brightness-high";
}

public class BrightnessLowFillIcon : BaseIcon
{
    protected override string IconSource => "brightness-low-fill";
}

public class BrightnessLowIcon : BaseIcon
{
    protected override string IconSource => "brightness-low";
}

public class BroadcastPinIcon : BaseIcon
{
    protected override string IconSource => "broadcast-pin";
}

public class BroadcastIcon : BaseIcon
{
    protected override string IconSource => "broadcast";
}

public class BrushFillIcon : BaseIcon
{
    protected override string IconSource => "brush-fill";
}

public class BrushIcon : BaseIcon
{
    protected override string IconSource => "brush";
}

public class BucketFillIcon : BaseIcon
{
    protected override string IconSource => "bucket-fill";
}

public class BucketIcon : BaseIcon
{
    protected override string IconSource => "bucket";
}

public class BugFillIcon : BaseIcon
{
    protected override string IconSource => "bug-fill";
}

public class BugIcon : BaseIcon
{
    protected override string IconSource => "bug";
}

public class BuildingIcon : BaseIcon
{
    protected override string IconSource => "building";
}

public class BullseyeIcon : BaseIcon
{
    protected override string IconSource => "bullseye";
}

public class CalculatorFillIcon : BaseIcon
{
    protected override string IconSource => "calculator-fill";
}

public class CalculatorIcon : BaseIcon
{
    protected override string IconSource => "calculator";
}

public class CalendarCheckFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-check-fill";
}

public class CalendarCheckIcon : BaseIcon
{
    protected override string IconSource => "calendar-check";
}

public class CalendarDateFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-date-fill";
}

public class CalendarDateIcon : BaseIcon
{
    protected override string IconSource => "calendar-date";
}

public class CalendarDayFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-day-fill";
}

public class CalendarDayIcon : BaseIcon
{
    protected override string IconSource => "calendar-day";
}

public class CalendarEventFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-event-fill";
}

public class CalendarEventIcon : BaseIcon
{
    protected override string IconSource => "calendar-event";
}

public class CalendarFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-fill";
}

public class CalendarMinusFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-minus-fill";
}

public class CalendarMinusIcon : BaseIcon
{
    protected override string IconSource => "calendar-minus";
}

public class CalendarMonthFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-month-fill";
}

public class CalendarMonthIcon : BaseIcon
{
    protected override string IconSource => "calendar-month";
}

public class CalendarPlusFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-plus-fill";
}

public class CalendarPlusIcon : BaseIcon
{
    protected override string IconSource => "calendar-plus";
}

public class CalendarRangeFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-range-fill";
}

public class CalendarRangeIcon : BaseIcon
{
    protected override string IconSource => "calendar-range";
}

public class CalendarWeekFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-week-fill";
}

public class CalendarWeekIcon : BaseIcon
{
    protected override string IconSource => "calendar-week";
}

public class CalendarXFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-x-fill";
}

public class CalendarXIcon : BaseIcon
{
    protected override string IconSource => "calendar-x";
}

public class CalendarIcon : BaseIcon
{
    protected override string IconSource => "calendar";
}

public class Calendar2CheckFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-check-fill";
}

public class Calendar2CheckIcon : BaseIcon
{
    protected override string IconSource => "calendar2-check";
}

public class Calendar2DateFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-date-fill";
}

public class Calendar2DateIcon : BaseIcon
{
    protected override string IconSource => "calendar2-date";
}

public class Calendar2DayFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-day-fill";
}

public class Calendar2DayIcon : BaseIcon
{
    protected override string IconSource => "calendar2-day";
}

public class Calendar2EventFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-event-fill";
}

public class Calendar2EventIcon : BaseIcon
{
    protected override string IconSource => "calendar2-event";
}

public class Calendar2FillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-fill";
}

public class Calendar2MinusFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-minus-fill";
}

public class Calendar2MinusIcon : BaseIcon
{
    protected override string IconSource => "calendar2-minus";
}

public class Calendar2MonthFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-month-fill";
}

public class Calendar2MonthIcon : BaseIcon
{
    protected override string IconSource => "calendar2-month";
}

public class Calendar2PlusFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-plus-fill";
}

public class Calendar2PlusIcon : BaseIcon
{
    protected override string IconSource => "calendar2-plus";
}

public class Calendar2RangeFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-range-fill";
}

public class Calendar2RangeIcon : BaseIcon
{
    protected override string IconSource => "calendar2-range";
}

public class Calendar2WeekFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-week-fill";
}

public class Calendar2WeekIcon : BaseIcon
{
    protected override string IconSource => "calendar2-week";
}

public class Calendar2XFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-x-fill";
}

public class Calendar2XIcon : BaseIcon
{
    protected override string IconSource => "calendar2-x";
}

public class Calendar2Icon : BaseIcon
{
    protected override string IconSource => "calendar2";
}

public class Calendar3EventFillIcon : BaseIcon
{
    protected override string IconSource => "calendar3-event-fill";
}

public class Calendar3EventIcon : BaseIcon
{
    protected override string IconSource => "calendar3-event";
}

public class Calendar3FillIcon : BaseIcon
{
    protected override string IconSource => "calendar3-fill";
}

public class Calendar3RangeFillIcon : BaseIcon
{
    protected override string IconSource => "calendar3-range-fill";
}

public class Calendar3RangeIcon : BaseIcon
{
    protected override string IconSource => "calendar3-range";
}

public class Calendar3WeekFillIcon : BaseIcon
{
    protected override string IconSource => "calendar3-week-fill";
}

public class Calendar3WeekIcon : BaseIcon
{
    protected override string IconSource => "calendar3-week";
}

public class Calendar3Icon : BaseIcon
{
    protected override string IconSource => "calendar3";
}

public class Calendar4EventIcon : BaseIcon
{
    protected override string IconSource => "calendar4-event";
}

public class Calendar4RangeIcon : BaseIcon
{
    protected override string IconSource => "calendar4-range";
}

public class Calendar4WeekIcon : BaseIcon
{
    protected override string IconSource => "calendar4-week";
}

public class Calendar4Icon : BaseIcon
{
    protected override string IconSource => "calendar4";
}

public class CameraFillIcon : BaseIcon
{
    protected override string IconSource => "camera-fill";
}

public class CameraReelsFillIcon : BaseIcon
{
    protected override string IconSource => "camera-reels-fill";
}

public class CameraReelsIcon : BaseIcon
{
    protected override string IconSource => "camera-reels";
}

public class CameraVideoFillIcon : BaseIcon
{
    protected override string IconSource => "camera-video-fill";
}

public class CameraVideoOffFillIcon : BaseIcon
{
    protected override string IconSource => "camera-video-off-fill";
}

public class CameraVideoOffIcon : BaseIcon
{
    protected override string IconSource => "camera-video-off";
}

public class CameraVideoIcon : BaseIcon
{
    protected override string IconSource => "camera-video";
}

public class CameraIcon : BaseIcon
{
    protected override string IconSource => "camera";
}

public class Camera2Icon : BaseIcon
{
    protected override string IconSource => "camera2";
}

public class CapslockFillIcon : BaseIcon
{
    protected override string IconSource => "capslock-fill";
}

public class CapslockIcon : BaseIcon
{
    protected override string IconSource => "capslock";
}

public class CardChecklistIcon : BaseIcon
{
    protected override string IconSource => "card-checklist";
}

public class CardHeadingIcon : BaseIcon
{
    protected override string IconSource => "card-heading";
}

public class CardImageIcon : BaseIcon
{
    protected override string IconSource => "card-image";
}

public class CardListIcon : BaseIcon
{
    protected override string IconSource => "card-list";
}

public class CardTextIcon : BaseIcon
{
    protected override string IconSource => "card-text";
}

public class CaretDownFillIcon : BaseIcon
{
    protected override string IconSource => "caret-down-fill";
}

public class CaretDownSquareFillIcon : BaseIcon
{
    protected override string IconSource => "caret-down-square-fill";
}

public class CaretDownSquareIcon : BaseIcon
{
    protected override string IconSource => "caret-down-square";
}

public class CaretDownIcon : BaseIcon
{
    protected override string IconSource => "caret-down";
}

public class CaretLeftFillIcon : BaseIcon
{
    protected override string IconSource => "caret-left-fill";
}

public class CaretLeftSquareFillIcon : BaseIcon
{
    protected override string IconSource => "caret-left-square-fill";
}

public class CaretLeftSquareIcon : BaseIcon
{
    protected override string IconSource => "caret-left-square";
}

public class CaretLeftIcon : BaseIcon
{
    protected override string IconSource => "caret-left";
}

public class CaretRightFillIcon : BaseIcon
{
    protected override string IconSource => "caret-right-fill";
}

public class CaretRightSquareFillIcon : BaseIcon
{
    protected override string IconSource => "caret-right-square-fill";
}

public class CaretRightSquareIcon : BaseIcon
{
    protected override string IconSource => "caret-right-square";
}

public class CaretRightIcon : BaseIcon
{
    protected override string IconSource => "caret-right";
}

public class CaretUpFillIcon : BaseIcon
{
    protected override string IconSource => "caret-up-fill";
}

public class CaretUpSquareFillIcon : BaseIcon
{
    protected override string IconSource => "caret-up-square-fill";
}

public class CaretUpSquareIcon : BaseIcon
{
    protected override string IconSource => "caret-up-square";
}

public class CaretUpIcon : BaseIcon
{
    protected override string IconSource => "caret-up";
}

public class CartCheckFillIcon : BaseIcon
{
    protected override string IconSource => "cart-check-fill";
}

public class CartCheckIcon : BaseIcon
{
    protected override string IconSource => "cart-check";
}

public class CartDashFillIcon : BaseIcon
{
    protected override string IconSource => "cart-dash-fill";
}

public class CartDashIcon : BaseIcon
{
    protected override string IconSource => "cart-dash";
}

public class CartFillIcon : BaseIcon
{
    protected override string IconSource => "cart-fill";
}

public class CartPlusFillIcon : BaseIcon
{
    protected override string IconSource => "cart-plus-fill";
}

public class CartPlusIcon : BaseIcon
{
    protected override string IconSource => "cart-plus";
}

public class CartXFillIcon : BaseIcon
{
    protected override string IconSource => "cart-x-fill";
}

public class CartXIcon : BaseIcon
{
    protected override string IconSource => "cart-x";
}

public class CartIcon : BaseIcon
{
    protected override string IconSource => "cart";
}

public class Cart2Icon : BaseIcon
{
    protected override string IconSource => "cart2";
}

public class Cart3Icon : BaseIcon
{
    protected override string IconSource => "cart3";
}

public class Cart4Icon : BaseIcon
{
    protected override string IconSource => "cart4";
}

public class CashStackIcon : BaseIcon
{
    protected override string IconSource => "cash-stack";
}

public class CashIcon : BaseIcon
{
    protected override string IconSource => "cash";
}

public class CastIcon : BaseIcon
{
    protected override string IconSource => "cast";
}

public class ChatDotsFillIcon : BaseIcon
{
    protected override string IconSource => "chat-dots-fill";
}

public class ChatDotsIcon : BaseIcon
{
    protected override string IconSource => "chat-dots";
}

public class ChatFillIcon : BaseIcon
{
    protected override string IconSource => "chat-fill";
}

public class ChatLeftDotsFillIcon : BaseIcon
{
    protected override string IconSource => "chat-left-dots-fill";
}

public class ChatLeftDotsIcon : BaseIcon
{
    protected override string IconSource => "chat-left-dots";
}

public class ChatLeftFillIcon : BaseIcon
{
    protected override string IconSource => "chat-left-fill";
}

public class ChatLeftQuoteFillIcon : BaseIcon
{
    protected override string IconSource => "chat-left-quote-fill";
}

public class ChatLeftQuoteIcon : BaseIcon
{
    protected override string IconSource => "chat-left-quote";
}

public class ChatLeftTextFillIcon : BaseIcon
{
    protected override string IconSource => "chat-left-text-fill";
}

public class ChatLeftTextIcon : BaseIcon
{
    protected override string IconSource => "chat-left-text";
}

public class ChatLeftIcon : BaseIcon
{
    protected override string IconSource => "chat-left";
}

public class ChatQuoteFillIcon : BaseIcon
{
    protected override string IconSource => "chat-quote-fill";
}

public class ChatQuoteIcon : BaseIcon
{
    protected override string IconSource => "chat-quote";
}

public class ChatRightDotsFillIcon : BaseIcon
{
    protected override string IconSource => "chat-right-dots-fill";
}

public class ChatRightDotsIcon : BaseIcon
{
    protected override string IconSource => "chat-right-dots";
}

public class ChatRightFillIcon : BaseIcon
{
    protected override string IconSource => "chat-right-fill";
}

public class ChatRightQuoteFillIcon : BaseIcon
{
    protected override string IconSource => "chat-right-quote-fill";
}

public class ChatRightQuoteIcon : BaseIcon
{
    protected override string IconSource => "chat-right-quote";
}

public class ChatRightTextFillIcon : BaseIcon
{
    protected override string IconSource => "chat-right-text-fill";
}

public class ChatRightTextIcon : BaseIcon
{
    protected override string IconSource => "chat-right-text";
}

public class ChatRightIcon : BaseIcon
{
    protected override string IconSource => "chat-right";
}

public class ChatSquareDotsFillIcon : BaseIcon
{
    protected override string IconSource => "chat-square-dots-fill";
}

public class ChatSquareDotsIcon : BaseIcon
{
    protected override string IconSource => "chat-square-dots";
}

public class ChatSquareFillIcon : BaseIcon
{
    protected override string IconSource => "chat-square-fill";
}

public class ChatSquareQuoteFillIcon : BaseIcon
{
    protected override string IconSource => "chat-square-quote-fill";
}

public class ChatSquareQuoteIcon : BaseIcon
{
    protected override string IconSource => "chat-square-quote";
}

public class ChatSquareTextFillIcon : BaseIcon
{
    protected override string IconSource => "chat-square-text-fill";
}

public class ChatSquareTextIcon : BaseIcon
{
    protected override string IconSource => "chat-square-text";
}

public class ChatSquareIcon : BaseIcon
{
    protected override string IconSource => "chat-square";
}

public class ChatTextFillIcon : BaseIcon
{
    protected override string IconSource => "chat-text-fill";
}

public class ChatTextIcon : BaseIcon
{
    protected override string IconSource => "chat-text";
}

public class ChatIcon : BaseIcon
{
    protected override string IconSource => "chat";
}

public class CheckAllIcon : BaseIcon
{
    protected override string IconSource => "check-all";
}

public class CheckCircleFillIcon : BaseIcon
{
    protected override string IconSource => "check-circle-fill";
}

public class CheckCircleIcon : BaseIcon
{
    protected override string IconSource => "check-circle";
}

public class CheckSquareFillIcon : BaseIcon
{
    protected override string IconSource => "check-square-fill";
}

public class CheckSquareIcon : BaseIcon
{
    protected override string IconSource => "check-square";
}

public class CheckIcon : BaseIcon
{
    protected override string IconSource => "check";
}

public class Check2AllIcon : BaseIcon
{
    protected override string IconSource => "check2-all";
}

public class Check2CircleIcon : BaseIcon
{
    protected override string IconSource => "check2-circle";
}

public class Check2SquareIcon : BaseIcon
{
    protected override string IconSource => "check2-square";
}

public class Check2Icon : BaseIcon
{
    protected override string IconSource => "check2";
}

public class ChevronBarContractIcon : BaseIcon
{
    protected override string IconSource => "chevron-bar-contract";
}

public class ChevronBarDownIcon : BaseIcon
{
    protected override string IconSource => "chevron-bar-down";
}

public class ChevronBarExpandIcon : BaseIcon
{
    protected override string IconSource => "chevron-bar-expand";
}

public class ChevronBarLeftIcon : BaseIcon
{
    protected override string IconSource => "chevron-bar-left";
}

public class ChevronBarRightIcon : BaseIcon
{
    protected override string IconSource => "chevron-bar-right";
}

public class ChevronBarUpIcon : BaseIcon
{
    protected override string IconSource => "chevron-bar-up";
}

public class ChevronCompactDownIcon : BaseIcon
{
    protected override string IconSource => "chevron-compact-down";
}

public class ChevronCompactLeftIcon : BaseIcon
{
    protected override string IconSource => "chevron-compact-left";
}

public class ChevronCompactRightIcon : BaseIcon
{
    protected override string IconSource => "chevron-compact-right";
}

public class ChevronCompactUpIcon : BaseIcon
{
    protected override string IconSource => "chevron-compact-up";
}

public class ChevronContractIcon : BaseIcon
{
    protected override string IconSource => "chevron-contract";
}

public class ChevronDoubleDownIcon : BaseIcon
{
    protected override string IconSource => "chevron-double-down";
}

public class ChevronDoubleLeftIcon : BaseIcon
{
    protected override string IconSource => "chevron-double-left";
}

public class ChevronDoubleRightIcon : BaseIcon
{
    protected override string IconSource => "chevron-double-right";
}

public class ChevronDoubleUpIcon : BaseIcon
{
    protected override string IconSource => "chevron-double-up";
}

public class ChevronDownIcon : BaseIcon
{
    protected override string IconSource => "chevron-down";
}

public class ChevronExpandIcon : BaseIcon
{
    protected override string IconSource => "chevron-expand";
}

public class ChevronLeftIcon : BaseIcon
{
    protected override string IconSource => "chevron-left";
}

public class ChevronRightIcon : BaseIcon
{
    protected override string IconSource => "chevron-right";
}

public class ChevronUpIcon : BaseIcon
{
    protected override string IconSource => "chevron-up";
}

public class CircleFillIcon : BaseIcon
{
    protected override string IconSource => "circle-fill";
}

public class CircleHalfIcon : BaseIcon
{
    protected override string IconSource => "circle-half";
}

public class CircleSquareIcon : BaseIcon
{
    protected override string IconSource => "circle-square";
}

public class CircleIcon : BaseIcon
{
    protected override string IconSource => "circle";
}

public class ClipboardCheckIcon : BaseIcon
{
    protected override string IconSource => "clipboard-check";
}

public class ClipboardDataIcon : BaseIcon
{
    protected override string IconSource => "clipboard-data";
}

public class ClipboardMinusIcon : BaseIcon
{
    protected override string IconSource => "clipboard-minus";
}

public class ClipboardPlusIcon : BaseIcon
{
    protected override string IconSource => "clipboard-plus";
}

public class ClipboardXIcon : BaseIcon
{
    protected override string IconSource => "clipboard-x";
}

public class ClipboardIcon : BaseIcon
{
    protected override string IconSource => "clipboard";
}

public class ClockFillIcon : BaseIcon
{
    protected override string IconSource => "clock-fill";
}

public class ClockHistoryIcon : BaseIcon
{
    protected override string IconSource => "clock-history";
}

public class ClockIcon : BaseIcon
{
    protected override string IconSource => "clock";
}

public class CloudArrowDownFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-arrow-down-fill";
}

public class CloudArrowDownIcon : BaseIcon
{
    protected override string IconSource => "cloud-arrow-down";
}

public class CloudArrowUpFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-arrow-up-fill";
}

public class CloudArrowUpIcon : BaseIcon
{
    protected override string IconSource => "cloud-arrow-up";
}

public class CloudCheckFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-check-fill";
}

public class CloudCheckIcon : BaseIcon
{
    protected override string IconSource => "cloud-check";
}

public class CloudDownloadFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-download-fill";
}

public class CloudDownloadIcon : BaseIcon
{
    protected override string IconSource => "cloud-download";
}

public class CloudDrizzleFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-drizzle-fill";
}

public class CloudDrizzleIcon : BaseIcon
{
    protected override string IconSource => "cloud-drizzle";
}

public class CloudFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-fill";
}

public class CloudFogFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-fog-fill";
}

public class CloudFogIcon : BaseIcon
{
    protected override string IconSource => "cloud-fog";
}

public class CloudFog2FillIcon : BaseIcon
{
    protected override string IconSource => "cloud-fog2-fill";
}

public class CloudFog2Icon : BaseIcon
{
    protected override string IconSource => "cloud-fog2";
}

public class CloudHailFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-hail-fill";
}

public class CloudHailIcon : BaseIcon
{
    protected override string IconSource => "cloud-hail";
}

public class CloudHaze1Icon : BaseIcon
{
    protected override string IconSource => "cloud-haze-1";
}

public class CloudHazeFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-haze-fill";
}

public class CloudHazeIcon : BaseIcon
{
    protected override string IconSource => "cloud-haze";
}

public class CloudHaze2FillIcon : BaseIcon
{
    protected override string IconSource => "cloud-haze2-fill";
}

public class CloudLightningFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-lightning-fill";
}

public class CloudLightningRainFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-lightning-rain-fill";
}

public class CloudLightningRainIcon : BaseIcon
{
    protected override string IconSource => "cloud-lightning-rain";
}

public class CloudLightningIcon : BaseIcon
{
    protected override string IconSource => "cloud-lightning";
}

public class CloudMinusFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-minus-fill";
}

public class CloudMinusIcon : BaseIcon
{
    protected override string IconSource => "cloud-minus";
}

public class CloudMoonFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-moon-fill";
}

public class CloudMoonIcon : BaseIcon
{
    protected override string IconSource => "cloud-moon";
}

public class CloudPlusFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-plus-fill";
}

public class CloudPlusIcon : BaseIcon
{
    protected override string IconSource => "cloud-plus";
}

public class CloudRainFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-rain-fill";
}

public class CloudRainHeavyFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-rain-heavy-fill";
}

public class CloudRainHeavyIcon : BaseIcon
{
    protected override string IconSource => "cloud-rain-heavy";
}

public class CloudRainIcon : BaseIcon
{
    protected override string IconSource => "cloud-rain";
}

public class CloudSlashFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-slash-fill";
}

public class CloudSlashIcon : BaseIcon
{
    protected override string IconSource => "cloud-slash";
}

public class CloudSleetFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-sleet-fill";
}

public class CloudSleetIcon : BaseIcon
{
    protected override string IconSource => "cloud-sleet";
}

public class CloudSnowFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-snow-fill";
}

public class CloudSnowIcon : BaseIcon
{
    protected override string IconSource => "cloud-snow";
}

public class CloudSunFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-sun-fill";
}

public class CloudSunIcon : BaseIcon
{
    protected override string IconSource => "cloud-sun";
}

public class CloudUploadFillIcon : BaseIcon
{
    protected override string IconSource => "cloud-upload-fill";
}

public class CloudUploadIcon : BaseIcon
{
    protected override string IconSource => "cloud-upload";
}

public class CloudIcon : BaseIcon
{
    protected override string IconSource => "cloud";
}

public class CloudsFillIcon : BaseIcon
{
    protected override string IconSource => "clouds-fill";
}

public class CloudsIcon : BaseIcon
{
    protected override string IconSource => "clouds";
}

public class CloudyFillIcon : BaseIcon
{
    protected override string IconSource => "cloudy-fill";
}

public class CloudyIcon : BaseIcon
{
    protected override string IconSource => "cloudy";
}

public class CodeSlashIcon : BaseIcon
{
    protected override string IconSource => "code-slash";
}

public class CodeSquareIcon : BaseIcon
{
    protected override string IconSource => "code-square";
}

public class CodeIcon : BaseIcon
{
    protected override string IconSource => "code";
}

public class CollectionFillIcon : BaseIcon
{
    protected override string IconSource => "collection-fill";
}

public class CollectionPlayFillIcon : BaseIcon
{
    protected override string IconSource => "collection-play-fill";
}

public class CollectionPlayIcon : BaseIcon
{
    protected override string IconSource => "collection-play";
}

public class CollectionIcon : BaseIcon
{
    protected override string IconSource => "collection";
}

public class ColumnsGapIcon : BaseIcon
{
    protected override string IconSource => "columns-gap";
}

public class ColumnsIcon : BaseIcon
{
    protected override string IconSource => "columns";
}

public class CommandIcon : BaseIcon
{
    protected override string IconSource => "command";
}

public class CompassFillIcon : BaseIcon
{
    protected override string IconSource => "compass-fill";
}

public class CompassIcon : BaseIcon
{
    protected override string IconSource => "compass";
}

public class ConeStripedIcon : BaseIcon
{
    protected override string IconSource => "cone-striped";
}

public class ConeIcon : BaseIcon
{
    protected override string IconSource => "cone";
}

public class ControllerIcon : BaseIcon
{
    protected override string IconSource => "controller";
}

public class CpuFillIcon : BaseIcon
{
    protected override string IconSource => "cpu-fill";
}

public class CpuIcon : BaseIcon
{
    protected override string IconSource => "cpu";
}

public class CreditCard2BackFillIcon : BaseIcon
{
    protected override string IconSource => "credit-card-2-back-fill";
}

public class CreditCard2BackIcon : BaseIcon
{
    protected override string IconSource => "credit-card-2-back";
}

public class CreditCard2FrontFillIcon : BaseIcon
{
    protected override string IconSource => "credit-card-2-front-fill";
}

public class CreditCard2FrontIcon : BaseIcon
{
    protected override string IconSource => "credit-card-2-front";
}

public class CreditCardFillIcon : BaseIcon
{
    protected override string IconSource => "credit-card-fill";
}

public class CreditCardIcon : BaseIcon
{
    protected override string IconSource => "credit-card";
}

public class CropIcon : BaseIcon
{
    protected override string IconSource => "crop";
}

public class CupFillIcon : BaseIcon
{
    protected override string IconSource => "cup-fill";
}

public class CupStrawIcon : BaseIcon
{
    protected override string IconSource => "cup-straw";
}

public class CupIcon : BaseIcon
{
    protected override string IconSource => "cup";
}

public class CursorFillIcon : BaseIcon
{
    protected override string IconSource => "cursor-fill";
}

public class CursorTextIcon : BaseIcon
{
    protected override string IconSource => "cursor-text";
}

public class CursorIcon : BaseIcon
{
    protected override string IconSource => "cursor";
}

public class DashCircleDottedIcon : BaseIcon
{
    protected override string IconSource => "dash-circle-dotted";
}

public class DashCircleFillIcon : BaseIcon
{
    protected override string IconSource => "dash-circle-fill";
}

public class DashCircleIcon : BaseIcon
{
    protected override string IconSource => "dash-circle";
}

public class DashSquareDottedIcon : BaseIcon
{
    protected override string IconSource => "dash-square-dotted";
}

public class DashSquareFillIcon : BaseIcon
{
    protected override string IconSource => "dash-square-fill";
}

public class DashSquareIcon : BaseIcon
{
    protected override string IconSource => "dash-square";
}

public class DashIcon : BaseIcon
{
    protected override string IconSource => "dash";
}

public class Diagram2FillIcon : BaseIcon
{
    protected override string IconSource => "diagram-2-fill";
}

public class Diagram2Icon : BaseIcon
{
    protected override string IconSource => "diagram-2";
}

public class Diagram3FillIcon : BaseIcon
{
    protected override string IconSource => "diagram-3-fill";
}

public class Diagram3Icon : BaseIcon
{
    protected override string IconSource => "diagram-3";
}

public class DiamondFillIcon : BaseIcon
{
    protected override string IconSource => "diamond-fill";
}

public class DiamondHalfIcon : BaseIcon
{
    protected override string IconSource => "diamond-half";
}

public class DiamondIcon : BaseIcon
{
    protected override string IconSource => "diamond";
}

public class Dice1FillIcon : BaseIcon
{
    protected override string IconSource => "dice-1-fill";
}

public class Dice1Icon : BaseIcon
{
    protected override string IconSource => "dice-1";
}

public class Dice2FillIcon : BaseIcon
{
    protected override string IconSource => "dice-2-fill";
}

public class Dice2Icon : BaseIcon
{
    protected override string IconSource => "dice-2";
}

public class Dice3FillIcon : BaseIcon
{
    protected override string IconSource => "dice-3-fill";
}

public class Dice3Icon : BaseIcon
{
    protected override string IconSource => "dice-3";
}

public class Dice4FillIcon : BaseIcon
{
    protected override string IconSource => "dice-4-fill";
}

public class Dice4Icon : BaseIcon
{
    protected override string IconSource => "dice-4";
}

public class Dice5FillIcon : BaseIcon
{
    protected override string IconSource => "dice-5-fill";
}

public class Dice5Icon : BaseIcon
{
    protected override string IconSource => "dice-5";
}

public class Dice6FillIcon : BaseIcon
{
    protected override string IconSource => "dice-6-fill";
}

public class Dice6Icon : BaseIcon
{
    protected override string IconSource => "dice-6";
}

public class DiscFillIcon : BaseIcon
{
    protected override string IconSource => "disc-fill";
}

public class DiscIcon : BaseIcon
{
    protected override string IconSource => "disc";
}

public class DiscordIcon : BaseIcon
{
    protected override string IconSource => "discord";
}

public class DisplayFillIcon : BaseIcon
{
    protected override string IconSource => "display-fill";
}

public class DisplayIcon : BaseIcon
{
    protected override string IconSource => "display";
}

public class DistributeHorizontalIcon : BaseIcon
{
    protected override string IconSource => "distribute-horizontal";
}

public class DistributeVerticalIcon : BaseIcon
{
    protected override string IconSource => "distribute-vertical";
}

public class DoorClosedFillIcon : BaseIcon
{
    protected override string IconSource => "door-closed-fill";
}

public class DoorClosedIcon : BaseIcon
{
    protected override string IconSource => "door-closed";
}

public class DoorOpenFillIcon : BaseIcon
{
    protected override string IconSource => "door-open-fill";
}

public class DoorOpenIcon : BaseIcon
{
    protected override string IconSource => "door-open";
}

public class DotIcon : BaseIcon
{
    protected override string IconSource => "dot";
}

public class DownloadIcon : BaseIcon
{
    protected override string IconSource => "download";
}

public class DropletFillIcon : BaseIcon
{
    protected override string IconSource => "droplet-fill";
}

public class DropletHalfIcon : BaseIcon
{
    protected override string IconSource => "droplet-half";
}

public class DropletIcon : BaseIcon
{
    protected override string IconSource => "droplet";
}

public class EarbudsIcon : BaseIcon
{
    protected override string IconSource => "earbuds";
}

public class EaselFillIcon : BaseIcon
{
    protected override string IconSource => "easel-fill";
}

public class EaselIcon : BaseIcon
{
    protected override string IconSource => "easel";
}

public class EggFillIcon : BaseIcon
{
    protected override string IconSource => "egg-fill";
}

public class EggFriedIcon : BaseIcon
{
    protected override string IconSource => "egg-fried";
}

public class EggIcon : BaseIcon
{
    protected override string IconSource => "egg";
}

public class EjectFillIcon : BaseIcon
{
    protected override string IconSource => "eject-fill";
}

public class EjectIcon : BaseIcon
{
    protected override string IconSource => "eject";
}

public class EmojiAngryFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-angry-fill";
}

public class EmojiAngryIcon : BaseIcon
{
    protected override string IconSource => "emoji-angry";
}

public class EmojiDizzyFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-dizzy-fill";
}

public class EmojiDizzyIcon : BaseIcon
{
    protected override string IconSource => "emoji-dizzy";
}

public class EmojiExpressionlessFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-expressionless-fill";
}

public class EmojiExpressionlessIcon : BaseIcon
{
    protected override string IconSource => "emoji-expressionless";
}

public class EmojiFrownFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-frown-fill";
}

public class EmojiFrownIcon : BaseIcon
{
    protected override string IconSource => "emoji-frown";
}

public class EmojiHeartEyesFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-heart-eyes-fill";
}

public class EmojiHeartEyesIcon : BaseIcon
{
    protected override string IconSource => "emoji-heart-eyes";
}

public class EmojiLaughingFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-laughing-fill";
}

public class EmojiLaughingIcon : BaseIcon
{
    protected override string IconSource => "emoji-laughing";
}

public class EmojiNeutralFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-neutral-fill";
}

public class EmojiNeutralIcon : BaseIcon
{
    protected override string IconSource => "emoji-neutral";
}

public class EmojiSmileFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-smile-fill";
}

public class EmojiSmileUpsideDownFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-smile-upside-down-fill";
}

public class EmojiSmileUpsideDownIcon : BaseIcon
{
    protected override string IconSource => "emoji-smile-upside-down";
}

public class EmojiSmileIcon : BaseIcon
{
    protected override string IconSource => "emoji-smile";
}

public class EmojiSunglassesFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-sunglasses-fill";
}

public class EmojiSunglassesIcon : BaseIcon
{
    protected override string IconSource => "emoji-sunglasses";
}

public class EmojiWinkFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-wink-fill";
}

public class EmojiWinkIcon : BaseIcon
{
    protected override string IconSource => "emoji-wink";
}

public class EnvelopeFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-fill";
}

public class EnvelopeOpenFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-open-fill";
}

public class EnvelopeOpenIcon : BaseIcon
{
    protected override string IconSource => "envelope-open";
}

public class EnvelopeIcon : BaseIcon
{
    protected override string IconSource => "envelope";
}

public class EraserFillIcon : BaseIcon
{
    protected override string IconSource => "eraser-fill";
}

public class EraserIcon : BaseIcon
{
    protected override string IconSource => "eraser";
}

public class ExclamationCircleFillIcon : BaseIcon
{
    protected override string IconSource => "exclamation-circle-fill";
}

public class ExclamationCircleIcon : BaseIcon
{
    protected override string IconSource => "exclamation-circle";
}

public class ExclamationDiamondFillIcon : BaseIcon
{
    protected override string IconSource => "exclamation-diamond-fill";
}

public class ExclamationDiamondIcon : BaseIcon
{
    protected override string IconSource => "exclamation-diamond";
}

public class ExclamationOctagonFillIcon : BaseIcon
{
    protected override string IconSource => "exclamation-octagon-fill";
}

public class ExclamationOctagonIcon : BaseIcon
{
    protected override string IconSource => "exclamation-octagon";
}

public class ExclamationSquareFillIcon : BaseIcon
{
    protected override string IconSource => "exclamation-square-fill";
}

public class ExclamationSquareIcon : BaseIcon
{
    protected override string IconSource => "exclamation-square";
}

public class ExclamationTriangleFillIcon : BaseIcon
{
    protected override string IconSource => "exclamation-triangle-fill";
}

public class ExclamationTriangleIcon : BaseIcon
{
    protected override string IconSource => "exclamation-triangle";
}

public class ExclamationIcon : BaseIcon
{
    protected override string IconSource => "exclamation";
}

public class ExcludeIcon : BaseIcon
{
    protected override string IconSource => "exclude";
}

public class EyeFillIcon : BaseIcon
{
    protected override string IconSource => "eye-fill";
}

public class EyeSlashFillIcon : BaseIcon
{
    protected override string IconSource => "eye-slash-fill";
}

public class EyeSlashIcon : BaseIcon
{
    protected override string IconSource => "eye-slash";
}

public class EyeIcon : BaseIcon
{
    protected override string IconSource => "eye";
}

public class EyedropperIcon : BaseIcon
{
    protected override string IconSource => "eyedropper";
}

public class EyeglassesIcon : BaseIcon
{
    protected override string IconSource => "eyeglasses";
}

public class FacebookIcon : BaseIcon
{
    protected override string IconSource => "facebook";
}

public class FileArrowDownFillIcon : BaseIcon
{
    protected override string IconSource => "file-arrow-down-fill";
}

public class FileArrowDownIcon : BaseIcon
{
    protected override string IconSource => "file-arrow-down";
}

public class FileArrowUpFillIcon : BaseIcon
{
    protected override string IconSource => "file-arrow-up-fill";
}

public class FileArrowUpIcon : BaseIcon
{
    protected override string IconSource => "file-arrow-up";
}

public class FileBarGraphFillIcon : BaseIcon
{
    protected override string IconSource => "file-bar-graph-fill";
}

public class FileBarGraphIcon : BaseIcon
{
    protected override string IconSource => "file-bar-graph";
}

public class FileBinaryFillIcon : BaseIcon
{
    protected override string IconSource => "file-binary-fill";
}

public class FileBinaryIcon : BaseIcon
{
    protected override string IconSource => "file-binary";
}

public class FileBreakFillIcon : BaseIcon
{
    protected override string IconSource => "file-break-fill";
}

public class FileBreakIcon : BaseIcon
{
    protected override string IconSource => "file-break";
}

public class FileCheckFillIcon : BaseIcon
{
    protected override string IconSource => "file-check-fill";
}

public class FileCheckIcon : BaseIcon
{
    protected override string IconSource => "file-check";
}

public class FileCodeFillIcon : BaseIcon
{
    protected override string IconSource => "file-code-fill";
}

public class FileCodeIcon : BaseIcon
{
    protected override string IconSource => "file-code";
}

public class FileDiffFillIcon : BaseIcon
{
    protected override string IconSource => "file-diff-fill";
}

public class FileDiffIcon : BaseIcon
{
    protected override string IconSource => "file-diff";
}

public class FileEarmarkArrowDownFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-arrow-down-fill";
}

public class FileEarmarkArrowDownIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-arrow-down";
}

public class FileEarmarkArrowUpFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-arrow-up-fill";
}

public class FileEarmarkArrowUpIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-arrow-up";
}

public class FileEarmarkBarGraphFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-bar-graph-fill";
}

public class FileEarmarkBarGraphIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-bar-graph";
}

public class FileEarmarkBinaryFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-binary-fill";
}

public class FileEarmarkBinaryIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-binary";
}

public class FileEarmarkBreakFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-break-fill";
}

public class FileEarmarkBreakIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-break";
}

public class FileEarmarkCheckFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-check-fill";
}

public class FileEarmarkCheckIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-check";
}

public class FileEarmarkCodeFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-code-fill";
}

public class FileEarmarkCodeIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-code";
}

public class FileEarmarkDiffFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-diff-fill";
}

public class FileEarmarkDiffIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-diff";
}

public class FileEarmarkEaselFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-easel-fill";
}

public class FileEarmarkEaselIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-easel";
}

public class FileEarmarkExcelFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-excel-fill";
}

public class FileEarmarkExcelIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-excel";
}

public class FileEarmarkFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-fill";
}

public class FileEarmarkFontFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-font-fill";
}

public class FileEarmarkFontIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-font";
}

public class FileEarmarkImageFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-image-fill";
}

public class FileEarmarkImageIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-image";
}

public class FileEarmarkLockFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-lock-fill";
}

public class FileEarmarkLockIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-lock";
}

public class FileEarmarkLock2FillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-lock2-fill";
}

public class FileEarmarkLock2Icon : BaseIcon
{
    protected override string IconSource => "file-earmark-lock2";
}

public class FileEarmarkMedicalFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-medical-fill";
}

public class FileEarmarkMedicalIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-medical";
}

public class FileEarmarkMinusFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-minus-fill";
}

public class FileEarmarkMinusIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-minus";
}

public class FileEarmarkMusicFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-music-fill";
}

public class FileEarmarkMusicIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-music";
}

public class FileEarmarkPersonFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-person-fill";
}

public class FileEarmarkPersonIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-person";
}

public class FileEarmarkPlayFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-play-fill";
}

public class FileEarmarkPlayIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-play";
}

public class FileEarmarkPlusFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-plus-fill";
}

public class FileEarmarkPlusIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-plus";
}

public class FileEarmarkPostFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-post-fill";
}

public class FileEarmarkPostIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-post";
}

public class FileEarmarkPptFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-ppt-fill";
}

public class FileEarmarkPptIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-ppt";
}

public class FileEarmarkRichtextFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-richtext-fill";
}

public class FileEarmarkRichtextIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-richtext";
}

public class FileEarmarkRuledFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-ruled-fill";
}

public class FileEarmarkRuledIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-ruled";
}

public class FileEarmarkSlidesFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-slides-fill";
}

public class FileEarmarkSlidesIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-slides";
}

public class FileEarmarkSpreadsheetFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-spreadsheet-fill";
}

public class FileEarmarkSpreadsheetIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-spreadsheet";
}

public class FileEarmarkTextFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-text-fill";
}

public class FileEarmarkTextIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-text";
}

public class FileEarmarkWordFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-word-fill";
}

public class FileEarmarkWordIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-word";
}

public class FileEarmarkXFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-x-fill";
}

public class FileEarmarkXIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-x";
}

public class FileEarmarkZipFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-zip-fill";
}

public class FileEarmarkZipIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-zip";
}

public class FileEarmarkIcon : BaseIcon
{
    protected override string IconSource => "file-earmark";
}

public class FileEaselFillIcon : BaseIcon
{
    protected override string IconSource => "file-easel-fill";
}

public class FileEaselIcon : BaseIcon
{
    protected override string IconSource => "file-easel";
}

public class FileExcelFillIcon : BaseIcon
{
    protected override string IconSource => "file-excel-fill";
}

public class FileExcelIcon : BaseIcon
{
    protected override string IconSource => "file-excel";
}

public class FileFillIcon : BaseIcon
{
    protected override string IconSource => "file-fill";
}

public class FileFontFillIcon : BaseIcon
{
    protected override string IconSource => "file-font-fill";
}

public class FileFontIcon : BaseIcon
{
    protected override string IconSource => "file-font";
}

public class FileImageFillIcon : BaseIcon
{
    protected override string IconSource => "file-image-fill";
}

public class FileImageIcon : BaseIcon
{
    protected override string IconSource => "file-image";
}

public class FileLockFillIcon : BaseIcon
{
    protected override string IconSource => "file-lock-fill";
}

public class FileLockIcon : BaseIcon
{
    protected override string IconSource => "file-lock";
}

public class FileLock2FillIcon : BaseIcon
{
    protected override string IconSource => "file-lock2-fill";
}

public class FileLock2Icon : BaseIcon
{
    protected override string IconSource => "file-lock2";
}

public class FileMedicalFillIcon : BaseIcon
{
    protected override string IconSource => "file-medical-fill";
}

public class FileMedicalIcon : BaseIcon
{
    protected override string IconSource => "file-medical";
}

public class FileMinusFillIcon : BaseIcon
{
    protected override string IconSource => "file-minus-fill";
}

public class FileMinusIcon : BaseIcon
{
    protected override string IconSource => "file-minus";
}

public class FileMusicFillIcon : BaseIcon
{
    protected override string IconSource => "file-music-fill";
}

public class FileMusicIcon : BaseIcon
{
    protected override string IconSource => "file-music";
}

public class FilePersonFillIcon : BaseIcon
{
    protected override string IconSource => "file-person-fill";
}

public class FilePersonIcon : BaseIcon
{
    protected override string IconSource => "file-person";
}

public class FilePlayFillIcon : BaseIcon
{
    protected override string IconSource => "file-play-fill";
}

public class FilePlayIcon : BaseIcon
{
    protected override string IconSource => "file-play";
}

public class FilePlusFillIcon : BaseIcon
{
    protected override string IconSource => "file-plus-fill";
}

public class FilePlusIcon : BaseIcon
{
    protected override string IconSource => "file-plus";
}

public class FilePostFillIcon : BaseIcon
{
    protected override string IconSource => "file-post-fill";
}

public class FilePostIcon : BaseIcon
{
    protected override string IconSource => "file-post";
}

public class FilePptFillIcon : BaseIcon
{
    protected override string IconSource => "file-ppt-fill";
}

public class FilePptIcon : BaseIcon
{
    protected override string IconSource => "file-ppt";
}

public class FileRichtextFillIcon : BaseIcon
{
    protected override string IconSource => "file-richtext-fill";
}

public class FileRichtextIcon : BaseIcon
{
    protected override string IconSource => "file-richtext";
}

public class FileRuledFillIcon : BaseIcon
{
    protected override string IconSource => "file-ruled-fill";
}

public class FileRuledIcon : BaseIcon
{
    protected override string IconSource => "file-ruled";
}

public class FileSlidesFillIcon : BaseIcon
{
    protected override string IconSource => "file-slides-fill";
}

public class FileSlidesIcon : BaseIcon
{
    protected override string IconSource => "file-slides";
}

public class FileSpreadsheetFillIcon : BaseIcon
{
    protected override string IconSource => "file-spreadsheet-fill";
}

public class FileSpreadsheetIcon : BaseIcon
{
    protected override string IconSource => "file-spreadsheet";
}

public class FileTextFillIcon : BaseIcon
{
    protected override string IconSource => "file-text-fill";
}

public class FileTextIcon : BaseIcon
{
    protected override string IconSource => "file-text";
}

public class FileWordFillIcon : BaseIcon
{
    protected override string IconSource => "file-word-fill";
}

public class FileWordIcon : BaseIcon
{
    protected override string IconSource => "file-word";
}

public class FileXFillIcon : BaseIcon
{
    protected override string IconSource => "file-x-fill";
}

public class FileXIcon : BaseIcon
{
    protected override string IconSource => "file-x";
}

public class FileZipFillIcon : BaseIcon
{
    protected override string IconSource => "file-zip-fill";
}

public class FileZipIcon : BaseIcon
{
    protected override string IconSource => "file-zip";
}

public class FileIcon : BaseIcon
{
    protected override string IconSource => "file";
}

public class FilesAltIcon : BaseIcon
{
    protected override string IconSource => "files-alt";
}

public class FilesIcon : BaseIcon
{
    protected override string IconSource => "files";
}

public class FilmIcon : BaseIcon
{
    protected override string IconSource => "film";
}

public class FilterCircleFillIcon : BaseIcon
{
    protected override string IconSource => "filter-circle-fill";
}

public class FilterCircleIcon : BaseIcon
{
    protected override string IconSource => "filter-circle";
}

public class FilterLeftIcon : BaseIcon
{
    protected override string IconSource => "filter-left";
}

public class FilterRightIcon : BaseIcon
{
    protected override string IconSource => "filter-right";
}

public class FilterSquareFillIcon : BaseIcon
{
    protected override string IconSource => "filter-square-fill";
}

public class FilterSquareIcon : BaseIcon
{
    protected override string IconSource => "filter-square";
}

public class FilterIcon : BaseIcon
{
    protected override string IconSource => "filter";
}

public class FlagFillIcon : BaseIcon
{
    protected override string IconSource => "flag-fill";
}

public class FlagIcon : BaseIcon
{
    protected override string IconSource => "flag";
}

public class Flower1Icon : BaseIcon
{
    protected override string IconSource => "flower1";
}

public class Flower2Icon : BaseIcon
{
    protected override string IconSource => "flower2";
}

public class Flower3Icon : BaseIcon
{
    protected override string IconSource => "flower3";
}

public class FolderCheckIcon : BaseIcon
{
    protected override string IconSource => "folder-check";
}

public class FolderFillIcon : BaseIcon
{
    protected override string IconSource => "folder-fill";
}

public class FolderMinusIcon : BaseIcon
{
    protected override string IconSource => "folder-minus";
}

public class FolderPlusIcon : BaseIcon
{
    protected override string IconSource => "folder-plus";
}

public class FolderSymlinkFillIcon : BaseIcon
{
    protected override string IconSource => "folder-symlink-fill";
}

public class FolderSymlinkIcon : BaseIcon
{
    protected override string IconSource => "folder-symlink";
}

public class FolderXIcon : BaseIcon
{
    protected override string IconSource => "folder-x";
}

public class FolderIcon : BaseIcon
{
    protected override string IconSource => "folder";
}

public class Folder2OpenIcon : BaseIcon
{
    protected override string IconSource => "folder2-open";
}

public class Folder2Icon : BaseIcon
{
    protected override string IconSource => "folder2";
}

public class FontsIcon : BaseIcon
{
    protected override string IconSource => "fonts";
}

public class ForwardFillIcon : BaseIcon
{
    protected override string IconSource => "forward-fill";
}

public class ForwardIcon : BaseIcon
{
    protected override string IconSource => "forward";
}

public class FrontIcon : BaseIcon
{
    protected override string IconSource => "front";
}

public class FullscreenExitIcon : BaseIcon
{
    protected override string IconSource => "fullscreen-exit";
}

public class FullscreenIcon : BaseIcon
{
    protected override string IconSource => "fullscreen";
}

public class FunnelFillIcon : BaseIcon
{
    protected override string IconSource => "funnel-fill";
}

public class FunnelIcon : BaseIcon
{
    protected override string IconSource => "funnel";
}

public class GearFillIcon : BaseIcon
{
    protected override string IconSource => "gear-fill";
}

public class GearWideConnectedIcon : BaseIcon
{
    protected override string IconSource => "gear-wide-connected";
}

public class GearWideIcon : BaseIcon
{
    protected override string IconSource => "gear-wide";
}

public class GearIcon : BaseIcon
{
    protected override string IconSource => "gear";
}

public class GemIcon : BaseIcon
{
    protected override string IconSource => "gem";
}

public class GeoAltFillIcon : BaseIcon
{
    protected override string IconSource => "geo-alt-fill";
}

public class GeoAltIcon : BaseIcon
{
    protected override string IconSource => "geo-alt";
}

public class GeoFillIcon : BaseIcon
{
    protected override string IconSource => "geo-fill";
}

public class GeoIcon : BaseIcon
{
    protected override string IconSource => "geo";
}

public class GiftFillIcon : BaseIcon
{
    protected override string IconSource => "gift-fill";
}

public class GiftIcon : BaseIcon
{
    protected override string IconSource => "gift";
}

public class GithubIcon : BaseIcon
{
    protected override string IconSource => "github";
}

public class GlobeIcon : BaseIcon
{
    protected override string IconSource => "globe";
}

public class Globe2Icon : BaseIcon
{
    protected override string IconSource => "globe2";
}

public class GoogleIcon : BaseIcon
{
    protected override string IconSource => "google";
}

public class GraphDownIcon : BaseIcon
{
    protected override string IconSource => "graph-down";
}

public class GraphUpIcon : BaseIcon
{
    protected override string IconSource => "graph-up";
}

public class Grid1x2FillIcon : BaseIcon
{
    protected override string IconSource => "grid-1x2-fill";
}

public class Grid1x2Icon : BaseIcon
{
    protected override string IconSource => "grid-1x2";
}

public class Grid3x2GapFillIcon : BaseIcon
{
    protected override string IconSource => "grid-3x2-gap-fill";
}

public class Grid3x2GapIcon : BaseIcon
{
    protected override string IconSource => "grid-3x2-gap";
}

public class Grid3x2Icon : BaseIcon
{
    protected override string IconSource => "grid-3x2";
}

public class Grid3x3GapFillIcon : BaseIcon
{
    protected override string IconSource => "grid-3x3-gap-fill";
}

public class Grid3x3GapIcon : BaseIcon
{
    protected override string IconSource => "grid-3x3-gap";
}

public class Grid3x3Icon : BaseIcon
{
    protected override string IconSource => "grid-3x3";
}

public class GridFillIcon : BaseIcon
{
    protected override string IconSource => "grid-fill";
}

public class GridIcon : BaseIcon
{
    protected override string IconSource => "grid";
}

public class GripHorizontalIcon : BaseIcon
{
    protected override string IconSource => "grip-horizontal";
}

public class GripVerticalIcon : BaseIcon
{
    protected override string IconSource => "grip-vertical";
}

public class HammerIcon : BaseIcon
{
    protected override string IconSource => "hammer";
}

public class HandIndexFillIcon : BaseIcon
{
    protected override string IconSource => "hand-index-fill";
}

public class HandIndexThumbFillIcon : BaseIcon
{
    protected override string IconSource => "hand-index-thumb-fill";
}

public class HandIndexThumbIcon : BaseIcon
{
    protected override string IconSource => "hand-index-thumb";
}

public class HandIndexIcon : BaseIcon
{
    protected override string IconSource => "hand-index";
}

public class HandThumbsDownFillIcon : BaseIcon
{
    protected override string IconSource => "hand-thumbs-down-fill";
}

public class HandThumbsDownIcon : BaseIcon
{
    protected override string IconSource => "hand-thumbs-down";
}

public class HandThumbsUpFillIcon : BaseIcon
{
    protected override string IconSource => "hand-thumbs-up-fill";
}

public class HandThumbsUpIcon : BaseIcon
{
    protected override string IconSource => "hand-thumbs-up";
}

public class HandbagFillIcon : BaseIcon
{
    protected override string IconSource => "handbag-fill";
}

public class HandbagIcon : BaseIcon
{
    protected override string IconSource => "handbag";
}

public class HashIcon : BaseIcon
{
    protected override string IconSource => "hash";
}

public class HddFillIcon : BaseIcon
{
    protected override string IconSource => "hdd-fill";
}

public class HddNetworkFillIcon : BaseIcon
{
    protected override string IconSource => "hdd-network-fill";
}

public class HddNetworkIcon : BaseIcon
{
    protected override string IconSource => "hdd-network";
}

public class HddRackFillIcon : BaseIcon
{
    protected override string IconSource => "hdd-rack-fill";
}

public class HddRackIcon : BaseIcon
{
    protected override string IconSource => "hdd-rack";
}

public class HddStackFillIcon : BaseIcon
{
    protected override string IconSource => "hdd-stack-fill";
}

public class HddStackIcon : BaseIcon
{
    protected override string IconSource => "hdd-stack";
}

public class HddIcon : BaseIcon
{
    protected override string IconSource => "hdd";
}

public class HeadphonesIcon : BaseIcon
{
    protected override string IconSource => "headphones";
}

public class HeadsetIcon : BaseIcon
{
    protected override string IconSource => "headset";
}

public class HeartFillIcon : BaseIcon
{
    protected override string IconSource => "heart-fill";
}

public class HeartHalfIcon : BaseIcon
{
    protected override string IconSource => "heart-half";
}

public class HeartIcon : BaseIcon
{
    protected override string IconSource => "heart";
}

public class HeptagonFillIcon : BaseIcon
{
    protected override string IconSource => "heptagon-fill";
}

public class HeptagonHalfIcon : BaseIcon
{
    protected override string IconSource => "heptagon-half";
}

public class HeptagonIcon : BaseIcon
{
    protected override string IconSource => "heptagon";
}

public class HexagonFillIcon : BaseIcon
{
    protected override string IconSource => "hexagon-fill";
}

public class HexagonHalfIcon : BaseIcon
{
    protected override string IconSource => "hexagon-half";
}

public class HexagonIcon : BaseIcon
{
    protected override string IconSource => "hexagon";
}

public class HourglassBottomIcon : BaseIcon
{
    protected override string IconSource => "hourglass-bottom";
}

public class HourglassSplitIcon : BaseIcon
{
    protected override string IconSource => "hourglass-split";
}

public class HourglassTopIcon : BaseIcon
{
    protected override string IconSource => "hourglass-top";
}

public class HourglassIcon : BaseIcon
{
    protected override string IconSource => "hourglass";
}

public class HouseDoorFillIcon : BaseIcon
{
    protected override string IconSource => "house-door-fill";
}

public class HouseDoorIcon : BaseIcon
{
    protected override string IconSource => "house-door";
}

public class HouseFillIcon : BaseIcon
{
    protected override string IconSource => "house-fill";
}

public class HouseIcon : BaseIcon
{
    protected override string IconSource => "house";
}

public class HrIcon : BaseIcon
{
    protected override string IconSource => "hr";
}

public class HurricaneIcon : BaseIcon
{
    protected override string IconSource => "hurricane";
}

public class ImageAltIcon : BaseIcon
{
    protected override string IconSource => "image-alt";
}

public class ImageFillIcon : BaseIcon
{
    protected override string IconSource => "image-fill";
}

public class ImageIcon : BaseIcon
{
    protected override string IconSource => "image";
}

public class ImagesIcon : BaseIcon
{
    protected override string IconSource => "images";
}

public class InboxFillIcon : BaseIcon
{
    protected override string IconSource => "inbox-fill";
}

public class InboxIcon : BaseIcon
{
    protected override string IconSource => "inbox";
}

public class InboxesFillIcon : BaseIcon
{
    protected override string IconSource => "inboxes-fill";
}

public class InboxesIcon : BaseIcon
{
    protected override string IconSource => "inboxes";
}

public class InfoCircleFillIcon : BaseIcon
{
    protected override string IconSource => "info-circle-fill";
}

public class InfoCircleIcon : BaseIcon
{
    protected override string IconSource => "info-circle";
}

public class InfoSquareFillIcon : BaseIcon
{
    protected override string IconSource => "info-square-fill";
}

public class InfoSquareIcon : BaseIcon
{
    protected override string IconSource => "info-square";
}

public class InfoIcon : BaseIcon
{
    protected override string IconSource => "info";
}

public class InputCursorTextIcon : BaseIcon
{
    protected override string IconSource => "input-cursor-text";
}

public class InputCursorIcon : BaseIcon
{
    protected override string IconSource => "input-cursor";
}

public class InstagramIcon : BaseIcon
{
    protected override string IconSource => "instagram";
}

public class IntersectIcon : BaseIcon
{
    protected override string IconSource => "intersect";
}

public class JournalAlbumIcon : BaseIcon
{
    protected override string IconSource => "journal-album";
}

public class JournalArrowDownIcon : BaseIcon
{
    protected override string IconSource => "journal-arrow-down";
}

public class JournalArrowUpIcon : BaseIcon
{
    protected override string IconSource => "journal-arrow-up";
}

public class JournalBookmarkFillIcon : BaseIcon
{
    protected override string IconSource => "journal-bookmark-fill";
}

public class JournalBookmarkIcon : BaseIcon
{
    protected override string IconSource => "journal-bookmark";
}

public class JournalCheckIcon : BaseIcon
{
    protected override string IconSource => "journal-check";
}

public class JournalCodeIcon : BaseIcon
{
    protected override string IconSource => "journal-code";
}

public class JournalMedicalIcon : BaseIcon
{
    protected override string IconSource => "journal-medical";
}

public class JournalMinusIcon : BaseIcon
{
    protected override string IconSource => "journal-minus";
}

public class JournalPlusIcon : BaseIcon
{
    protected override string IconSource => "journal-plus";
}

public class JournalRichtextIcon : BaseIcon
{
    protected override string IconSource => "journal-richtext";
}

public class JournalTextIcon : BaseIcon
{
    protected override string IconSource => "journal-text";
}

public class JournalXIcon : BaseIcon
{
    protected override string IconSource => "journal-x";
}

public class JournalIcon : BaseIcon
{
    protected override string IconSource => "journal";
}

public class JournalsIcon : BaseIcon
{
    protected override string IconSource => "journals";
}

public class JoystickIcon : BaseIcon
{
    protected override string IconSource => "joystick";
}

public class JustifyLeftIcon : BaseIcon
{
    protected override string IconSource => "justify-left";
}

public class JustifyRightIcon : BaseIcon
{
    protected override string IconSource => "justify-right";
}

public class JustifyIcon : BaseIcon
{
    protected override string IconSource => "justify";
}

public class KanbanFillIcon : BaseIcon
{
    protected override string IconSource => "kanban-fill";
}

public class KanbanIcon : BaseIcon
{
    protected override string IconSource => "kanban";
}

public class KeyFillIcon : BaseIcon
{
    protected override string IconSource => "key-fill";
}

public class KeyIcon : BaseIcon
{
    protected override string IconSource => "key";
}

public class KeyboardFillIcon : BaseIcon
{
    protected override string IconSource => "keyboard-fill";
}

public class KeyboardIcon : BaseIcon
{
    protected override string IconSource => "keyboard";
}

public class LadderIcon : BaseIcon
{
    protected override string IconSource => "ladder";
}

public class LampFillIcon : BaseIcon
{
    protected override string IconSource => "lamp-fill";
}

public class LampIcon : BaseIcon
{
    protected override string IconSource => "lamp";
}

public class LaptopFillIcon : BaseIcon
{
    protected override string IconSource => "laptop-fill";
}

public class LaptopIcon : BaseIcon
{
    protected override string IconSource => "laptop";
}

public class LayerBackwardIcon : BaseIcon
{
    protected override string IconSource => "layer-backward";
}

public class LayerForwardIcon : BaseIcon
{
    protected override string IconSource => "layer-forward";
}

public class LayersFillIcon : BaseIcon
{
    protected override string IconSource => "layers-fill";
}

public class LayersHalfIcon : BaseIcon
{
    protected override string IconSource => "layers-half";
}

public class LayersIcon : BaseIcon
{
    protected override string IconSource => "layers";
}

public class LayoutSidebarInsetReverseIcon : BaseIcon
{
    protected override string IconSource => "layout-sidebar-inset-reverse";
}

public class LayoutSidebarInsetIcon : BaseIcon
{
    protected override string IconSource => "layout-sidebar-inset";
}

public class LayoutSidebarReverseIcon : BaseIcon
{
    protected override string IconSource => "layout-sidebar-reverse";
}

public class LayoutSidebarIcon : BaseIcon
{
    protected override string IconSource => "layout-sidebar";
}

public class LayoutSplitIcon : BaseIcon
{
    protected override string IconSource => "layout-split";
}

public class LayoutTextSidebarReverseIcon : BaseIcon
{
    protected override string IconSource => "layout-text-sidebar-reverse";
}

public class LayoutTextSidebarIcon : BaseIcon
{
    protected override string IconSource => "layout-text-sidebar";
}

public class LayoutTextWindowReverseIcon : BaseIcon
{
    protected override string IconSource => "layout-text-window-reverse";
}

public class LayoutTextWindowIcon : BaseIcon
{
    protected override string IconSource => "layout-text-window";
}

public class LayoutThreeColumnsIcon : BaseIcon
{
    protected override string IconSource => "layout-three-columns";
}

public class LayoutWtfIcon : BaseIcon
{
    protected override string IconSource => "layout-wtf";
}

public class LifePreserverIcon : BaseIcon
{
    protected override string IconSource => "life-preserver";
}

public class LightbulbFillIcon : BaseIcon
{
    protected override string IconSource => "lightbulb-fill";
}

public class LightbulbOffFillIcon : BaseIcon
{
    protected override string IconSource => "lightbulb-off-fill";
}

public class LightbulbOffIcon : BaseIcon
{
    protected override string IconSource => "lightbulb-off";
}

public class LightbulbIcon : BaseIcon
{
    protected override string IconSource => "lightbulb";
}

public class LightningChargeFillIcon : BaseIcon
{
    protected override string IconSource => "lightning-charge-fill";
}

public class LightningChargeIcon : BaseIcon
{
    protected override string IconSource => "lightning-charge";
}

public class LightningFillIcon : BaseIcon
{
    protected override string IconSource => "lightning-fill";
}

public class LightningIcon : BaseIcon
{
    protected override string IconSource => "lightning";
}

public class Link45degIcon : BaseIcon
{
    protected override string IconSource => "link-45deg";
}

public class LinkIcon : BaseIcon
{
    protected override string IconSource => "link";
}

public class LinkedinIcon : BaseIcon
{
    protected override string IconSource => "linkedin";
}

public class ListCheckIcon : BaseIcon
{
    protected override string IconSource => "list-check";
}

public class ListNestedIcon : BaseIcon
{
    protected override string IconSource => "list-nested";
}

public class ListOlIcon : BaseIcon
{
    protected override string IconSource => "list-ol";
}

public class ListStarsIcon : BaseIcon
{
    protected override string IconSource => "list-stars";
}

public class ListTaskIcon : BaseIcon
{
    protected override string IconSource => "list-task";
}

public class ListUlIcon : BaseIcon
{
    protected override string IconSource => "list-ul";
}

public class ListIcon : BaseIcon
{
    protected override string IconSource => "list";
}

public class LockFillIcon : BaseIcon
{
    protected override string IconSource => "lock-fill";
}

public class LockIcon : BaseIcon
{
    protected override string IconSource => "lock";
}

public class MailboxIcon : BaseIcon
{
    protected override string IconSource => "mailbox";
}

public class Mailbox2Icon : BaseIcon
{
    protected override string IconSource => "mailbox2";
}

public class MapFillIcon : BaseIcon
{
    protected override string IconSource => "map-fill";
}

public class MapIcon : BaseIcon
{
    protected override string IconSource => "map";
}

public class MarkdownFillIcon : BaseIcon
{
    protected override string IconSource => "markdown-fill";
}

public class MarkdownIcon : BaseIcon
{
    protected override string IconSource => "markdown";
}

public class MaskIcon : BaseIcon
{
    protected override string IconSource => "mask";
}

public class MegaphoneFillIcon : BaseIcon
{
    protected override string IconSource => "megaphone-fill";
}

public class MegaphoneIcon : BaseIcon
{
    protected override string IconSource => "megaphone";
}

public class MenuAppFillIcon : BaseIcon
{
    protected override string IconSource => "menu-app-fill";
}

public class MenuAppIcon : BaseIcon
{
    protected override string IconSource => "menu-app";
}

public class MenuButtonFillIcon : BaseIcon
{
    protected override string IconSource => "menu-button-fill";
}

public class MenuButtonWideFillIcon : BaseIcon
{
    protected override string IconSource => "menu-button-wide-fill";
}

public class MenuButtonWideIcon : BaseIcon
{
    protected override string IconSource => "menu-button-wide";
}

public class MenuButtonIcon : BaseIcon
{
    protected override string IconSource => "menu-button";
}

public class MenuDownIcon : BaseIcon
{
    protected override string IconSource => "menu-down";
}

public class MenuUpIcon : BaseIcon
{
    protected override string IconSource => "menu-up";
}

public class MicFillIcon : BaseIcon
{
    protected override string IconSource => "mic-fill";
}

public class MicMuteFillIcon : BaseIcon
{
    protected override string IconSource => "mic-mute-fill";
}

public class MicMuteIcon : BaseIcon
{
    protected override string IconSource => "mic-mute";
}

public class MicIcon : BaseIcon
{
    protected override string IconSource => "mic";
}

public class MinecartLoadedIcon : BaseIcon
{
    protected override string IconSource => "minecart-loaded";
}

public class MinecartIcon : BaseIcon
{
    protected override string IconSource => "minecart";
}

public class MoistureIcon : BaseIcon
{
    protected override string IconSource => "moisture";
}

public class MoonFillIcon : BaseIcon
{
    protected override string IconSource => "moon-fill";
}

public class MoonStarsFillIcon : BaseIcon
{
    protected override string IconSource => "moon-stars-fill";
}

public class MoonStarsIcon : BaseIcon
{
    protected override string IconSource => "moon-stars";
}

public class MoonIcon : BaseIcon
{
    protected override string IconSource => "moon";
}

public class MouseFillIcon : BaseIcon
{
    protected override string IconSource => "mouse-fill";
}

public class MouseIcon : BaseIcon
{
    protected override string IconSource => "mouse";
}

public class Mouse2FillIcon : BaseIcon
{
    protected override string IconSource => "mouse2-fill";
}

public class Mouse2Icon : BaseIcon
{
    protected override string IconSource => "mouse2";
}

public class Mouse3FillIcon : BaseIcon
{
    protected override string IconSource => "mouse3-fill";
}

public class Mouse3Icon : BaseIcon
{
    protected override string IconSource => "mouse3";
}

public class MusicNoteBeamedIcon : BaseIcon
{
    protected override string IconSource => "music-note-beamed";
}

public class MusicNoteListIcon : BaseIcon
{
    protected override string IconSource => "music-note-list";
}

public class MusicNoteIcon : BaseIcon
{
    protected override string IconSource => "music-note";
}

public class MusicPlayerFillIcon : BaseIcon
{
    protected override string IconSource => "music-player-fill";
}

public class MusicPlayerIcon : BaseIcon
{
    protected override string IconSource => "music-player";
}

public class NewspaperIcon : BaseIcon
{
    protected override string IconSource => "newspaper";
}

public class NodeMinusFillIcon : BaseIcon
{
    protected override string IconSource => "node-minus-fill";
}

public class NodeMinusIcon : BaseIcon
{
    protected override string IconSource => "node-minus";
}

public class NodePlusFillIcon : BaseIcon
{
    protected override string IconSource => "node-plus-fill";
}

public class NodePlusIcon : BaseIcon
{
    protected override string IconSource => "node-plus";
}

public class NutFillIcon : BaseIcon
{
    protected override string IconSource => "nut-fill";
}

public class NutIcon : BaseIcon
{
    protected override string IconSource => "nut";
}

public class OctagonFillIcon : BaseIcon
{
    protected override string IconSource => "octagon-fill";
}

public class OctagonHalfIcon : BaseIcon
{
    protected override string IconSource => "octagon-half";
}

public class OctagonIcon : BaseIcon
{
    protected override string IconSource => "octagon";
}

public class OptionIcon : BaseIcon
{
    protected override string IconSource => "option";
}

public class OutletIcon : BaseIcon
{
    protected override string IconSource => "outlet";
}

public class PaintBucketIcon : BaseIcon
{
    protected override string IconSource => "paint-bucket";
}

public class PaletteFillIcon : BaseIcon
{
    protected override string IconSource => "palette-fill";
}

public class PaletteIcon : BaseIcon
{
    protected override string IconSource => "palette";
}

public class Palette2Icon : BaseIcon
{
    protected override string IconSource => "palette2";
}

public class PaperclipIcon : BaseIcon
{
    protected override string IconSource => "paperclip";
}

public class ParagraphIcon : BaseIcon
{
    protected override string IconSource => "paragraph";
}

public class PatchCheckFillIcon : BaseIcon
{
    protected override string IconSource => "patch-check-fill";
}

public class PatchCheckIcon : BaseIcon
{
    protected override string IconSource => "patch-check";
}

public class PatchExclamationFillIcon : BaseIcon
{
    protected override string IconSource => "patch-exclamation-fill";
}

public class PatchExclamationIcon : BaseIcon
{
    protected override string IconSource => "patch-exclamation";
}

public class PatchMinusFillIcon : BaseIcon
{
    protected override string IconSource => "patch-minus-fill";
}

public class PatchMinusIcon : BaseIcon
{
    protected override string IconSource => "patch-minus";
}

public class PatchPlusFillIcon : BaseIcon
{
    protected override string IconSource => "patch-plus-fill";
}

public class PatchPlusIcon : BaseIcon
{
    protected override string IconSource => "patch-plus";
}

public class PatchQuestionFillIcon : BaseIcon
{
    protected override string IconSource => "patch-question-fill";
}

public class PatchQuestionIcon : BaseIcon
{
    protected override string IconSource => "patch-question";
}

public class PauseBtnFillIcon : BaseIcon
{
    protected override string IconSource => "pause-btn-fill";
}

public class PauseBtnIcon : BaseIcon
{
    protected override string IconSource => "pause-btn";
}

public class PauseCircleFillIcon : BaseIcon
{
    protected override string IconSource => "pause-circle-fill";
}

public class PauseCircleIcon : BaseIcon
{
    protected override string IconSource => "pause-circle";
}

public class PauseFillIcon : BaseIcon
{
    protected override string IconSource => "pause-fill";
}

public class PauseIcon : BaseIcon
{
    protected override string IconSource => "pause";
}

public class PeaceFillIcon : BaseIcon
{
    protected override string IconSource => "peace-fill";
}

public class PeaceIcon : BaseIcon
{
    protected override string IconSource => "peace";
}

public class PenFillIcon : BaseIcon
{
    protected override string IconSource => "pen-fill";
}

public class PenIcon : BaseIcon
{
    protected override string IconSource => "pen";
}

public class PencilFillIcon : BaseIcon
{
    protected override string IconSource => "pencil-fill";
}

public class PencilSquareIcon : BaseIcon
{
    protected override string IconSource => "pencil-square";
}

public class PencilIcon : BaseIcon
{
    protected override string IconSource => "pencil";
}

public class PentagonFillIcon : BaseIcon
{
    protected override string IconSource => "pentagon-fill";
}

public class PentagonHalfIcon : BaseIcon
{
    protected override string IconSource => "pentagon-half";
}

public class PentagonIcon : BaseIcon
{
    protected override string IconSource => "pentagon";
}

public class PeopleFillIcon : BaseIcon
{
    protected override string IconSource => "people-fill";
}

public class PeopleIcon : BaseIcon
{
    protected override string IconSource => "people";
}

public class PercentIcon : BaseIcon
{
    protected override string IconSource => "percent";
}

public class PersonBadgeFillIcon : BaseIcon
{
    protected override string IconSource => "person-badge-fill";
}

public class PersonBadgeIcon : BaseIcon
{
    protected override string IconSource => "person-badge";
}

public class PersonBoundingBoxIcon : BaseIcon
{
    protected override string IconSource => "person-bounding-box";
}

public class PersonCheckFillIcon : BaseIcon
{
    protected override string IconSource => "person-check-fill";
}

public class PersonCheckIcon : BaseIcon
{
    protected override string IconSource => "person-check";
}

public class PersonCircleIcon : BaseIcon
{
    protected override string IconSource => "person-circle";
}

public class PersonDashFillIcon : BaseIcon
{
    protected override string IconSource => "person-dash-fill";
}

public class PersonDashIcon : BaseIcon
{
    protected override string IconSource => "person-dash";
}

public class PersonFillIcon : BaseIcon
{
    protected override string IconSource => "person-fill";
}

public class PersonLinesFillIcon : BaseIcon
{
    protected override string IconSource => "person-lines-fill";
}

public class PersonPlusFillIcon : BaseIcon
{
    protected override string IconSource => "person-plus-fill";
}

public class PersonPlusIcon : BaseIcon
{
    protected override string IconSource => "person-plus";
}

public class PersonSquareIcon : BaseIcon
{
    protected override string IconSource => "person-square";
}

public class PersonXFillIcon : BaseIcon
{
    protected override string IconSource => "person-x-fill";
}

public class PersonXIcon : BaseIcon
{
    protected override string IconSource => "person-x";
}

public class PersonIcon : BaseIcon
{
    protected override string IconSource => "person";
}

public class PhoneFillIcon : BaseIcon
{
    protected override string IconSource => "phone-fill";
}

public class PhoneLandscapeFillIcon : BaseIcon
{
    protected override string IconSource => "phone-landscape-fill";
}

public class PhoneLandscapeIcon : BaseIcon
{
    protected override string IconSource => "phone-landscape";
}

public class PhoneVibrateFillIcon : BaseIcon
{
    protected override string IconSource => "phone-vibrate-fill";
}

public class PhoneVibrateIcon : BaseIcon
{
    protected override string IconSource => "phone-vibrate";
}

public class PhoneIcon : BaseIcon
{
    protected override string IconSource => "phone";
}

public class PieChartFillIcon : BaseIcon
{
    protected override string IconSource => "pie-chart-fill";
}

public class PieChartIcon : BaseIcon
{
    protected override string IconSource => "pie-chart";
}

public class PinAngleFillIcon : BaseIcon
{
    protected override string IconSource => "pin-angle-fill";
}

public class PinAngleIcon : BaseIcon
{
    protected override string IconSource => "pin-angle";
}

public class PinFillIcon : BaseIcon
{
    protected override string IconSource => "pin-fill";
}

public class PinIcon : BaseIcon
{
    protected override string IconSource => "pin";
}

public class PipFillIcon : BaseIcon
{
    protected override string IconSource => "pip-fill";
}

public class PipIcon : BaseIcon
{
    protected override string IconSource => "pip";
}

public class PlayBtnFillIcon : BaseIcon
{
    protected override string IconSource => "play-btn-fill";
}

public class PlayBtnIcon : BaseIcon
{
    protected override string IconSource => "play-btn";
}

public class PlayCircleFillIcon : BaseIcon
{
    protected override string IconSource => "play-circle-fill";
}

public class PlayCircleIcon : BaseIcon
{
    protected override string IconSource => "play-circle";
}

public class PlayFillIcon : BaseIcon
{
    protected override string IconSource => "play-fill";
}

public class PlayIcon : BaseIcon
{
    protected override string IconSource => "play";
}

public class PlugFillIcon : BaseIcon
{
    protected override string IconSource => "plug-fill";
}

public class PlugIcon : BaseIcon
{
    protected override string IconSource => "plug";
}

public class PlusCircleDottedIcon : BaseIcon
{
    protected override string IconSource => "plus-circle-dotted";
}

public class PlusCircleFillIcon : BaseIcon
{
    protected override string IconSource => "plus-circle-fill";
}

public class PlusCircleIcon : BaseIcon
{
    protected override string IconSource => "plus-circle";
}

public class PlusSquareDottedIcon : BaseIcon
{
    protected override string IconSource => "plus-square-dotted";
}

public class PlusSquareFillIcon : BaseIcon
{
    protected override string IconSource => "plus-square-fill";
}

public class PlusSquareIcon : BaseIcon
{
    protected override string IconSource => "plus-square";
}

public class PlusIcon : BaseIcon
{
    protected override string IconSource => "plus";
}

public class PowerIcon : BaseIcon
{
    protected override string IconSource => "power";
}

public class PrinterFillIcon : BaseIcon
{
    protected override string IconSource => "printer-fill";
}

public class PrinterIcon : BaseIcon
{
    protected override string IconSource => "printer";
}

public class PuzzleFillIcon : BaseIcon
{
    protected override string IconSource => "puzzle-fill";
}

public class PuzzleIcon : BaseIcon
{
    protected override string IconSource => "puzzle";
}

public class QuestionCircleFillIcon : BaseIcon
{
    protected override string IconSource => "question-circle-fill";
}

public class QuestionCircleIcon : BaseIcon
{
    protected override string IconSource => "question-circle";
}

public class QuestionDiamondFillIcon : BaseIcon
{
    protected override string IconSource => "question-diamond-fill";
}

public class QuestionDiamondIcon : BaseIcon
{
    protected override string IconSource => "question-diamond";
}

public class QuestionOctagonFillIcon : BaseIcon
{
    protected override string IconSource => "question-octagon-fill";
}

public class QuestionOctagonIcon : BaseIcon
{
    protected override string IconSource => "question-octagon";
}

public class QuestionSquareFillIcon : BaseIcon
{
    protected override string IconSource => "question-square-fill";
}

public class QuestionSquareIcon : BaseIcon
{
    protected override string IconSource => "question-square";
}

public class QuestionIcon : BaseIcon
{
    protected override string IconSource => "question";
}

public class RainbowIcon : BaseIcon
{
    protected override string IconSource => "rainbow";
}

public class ReceiptCutoffIcon : BaseIcon
{
    protected override string IconSource => "receipt-cutoff";
}

public class ReceiptIcon : BaseIcon
{
    protected override string IconSource => "receipt";
}

public class Reception0Icon : BaseIcon
{
    protected override string IconSource => "reception-0";
}

public class Reception1Icon : BaseIcon
{
    protected override string IconSource => "reception-1";
}

public class Reception2Icon : BaseIcon
{
    protected override string IconSource => "reception-2";
}

public class Reception3Icon : BaseIcon
{
    protected override string IconSource => "reception-3";
}

public class Reception4Icon : BaseIcon
{
    protected override string IconSource => "reception-4";
}

public class RecordBtnFillIcon : BaseIcon
{
    protected override string IconSource => "record-btn-fill";
}

public class RecordBtnIcon : BaseIcon
{
    protected override string IconSource => "record-btn";
}

public class RecordCircleFillIcon : BaseIcon
{
    protected override string IconSource => "record-circle-fill";
}

public class RecordCircleIcon : BaseIcon
{
    protected override string IconSource => "record-circle";
}

public class RecordFillIcon : BaseIcon
{
    protected override string IconSource => "record-fill";
}

public class RecordIcon : BaseIcon
{
    protected override string IconSource => "record";
}

public class Record2FillIcon : BaseIcon
{
    protected override string IconSource => "record2-fill";
}

public class Record2Icon : BaseIcon
{
    protected override string IconSource => "record2";
}

public class ReplyAllFillIcon : BaseIcon
{
    protected override string IconSource => "reply-all-fill";
}

public class ReplyAllIcon : BaseIcon
{
    protected override string IconSource => "reply-all";
}

public class ReplyFillIcon : BaseIcon
{
    protected override string IconSource => "reply-fill";
}

public class ReplyIcon : BaseIcon
{
    protected override string IconSource => "reply";
}

public class RssFillIcon : BaseIcon
{
    protected override string IconSource => "rss-fill";
}

public class RssIcon : BaseIcon
{
    protected override string IconSource => "rss";
}

public class RulersIcon : BaseIcon
{
    protected override string IconSource => "rulers";
}

public class SaveFillIcon : BaseIcon
{
    protected override string IconSource => "save-fill";
}

public class SaveIcon : BaseIcon
{
    protected override string IconSource => "save";
}

public class Save2FillIcon : BaseIcon
{
    protected override string IconSource => "save2-fill";
}

public class Save2Icon : BaseIcon
{
    protected override string IconSource => "save2";
}

public class ScissorsIcon : BaseIcon
{
    protected override string IconSource => "scissors";
}

public class ScrewdriverIcon : BaseIcon
{
    protected override string IconSource => "screwdriver";
}

public class SearchIcon : BaseIcon
{
    protected override string IconSource => "search";
}

public class SegmentedNavIcon : BaseIcon
{
    protected override string IconSource => "segmented-nav";
}

public class ServerIcon : BaseIcon
{
    protected override string IconSource => "server";
}

public class ShareFillIcon : BaseIcon
{
    protected override string IconSource => "share-fill";
}

public class ShareIcon : BaseIcon
{
    protected override string IconSource => "share";
}

public class ShieldCheckIcon : BaseIcon
{
    protected override string IconSource => "shield-check";
}

public class ShieldExclamationIcon : BaseIcon
{
    protected override string IconSource => "shield-exclamation";
}

public class ShieldFillCheckIcon : BaseIcon
{
    protected override string IconSource => "shield-fill-check";
}

public class ShieldFillExclamationIcon : BaseIcon
{
    protected override string IconSource => "shield-fill-exclamation";
}

public class ShieldFillMinusIcon : BaseIcon
{
    protected override string IconSource => "shield-fill-minus";
}

public class ShieldFillPlusIcon : BaseIcon
{
    protected override string IconSource => "shield-fill-plus";
}

public class ShieldFillXIcon : BaseIcon
{
    protected override string IconSource => "shield-fill-x";
}

public class ShieldFillIcon : BaseIcon
{
    protected override string IconSource => "shield-fill";
}

public class ShieldLockFillIcon : BaseIcon
{
    protected override string IconSource => "shield-lock-fill";
}

public class ShieldLockIcon : BaseIcon
{
    protected override string IconSource => "shield-lock";
}

public class ShieldMinusIcon : BaseIcon
{
    protected override string IconSource => "shield-minus";
}

public class ShieldPlusIcon : BaseIcon
{
    protected override string IconSource => "shield-plus";
}

public class ShieldShadedIcon : BaseIcon
{
    protected override string IconSource => "shield-shaded";
}

public class ShieldSlashFillIcon : BaseIcon
{
    protected override string IconSource => "shield-slash-fill";
}

public class ShieldSlashIcon : BaseIcon
{
    protected override string IconSource => "shield-slash";
}

public class ShieldXIcon : BaseIcon
{
    protected override string IconSource => "shield-x";
}

public class ShieldIcon : BaseIcon
{
    protected override string IconSource => "shield";
}

public class ShiftFillIcon : BaseIcon
{
    protected override string IconSource => "shift-fill";
}

public class ShiftIcon : BaseIcon
{
    protected override string IconSource => "shift";
}

public class ShopWindowIcon : BaseIcon
{
    protected override string IconSource => "shop-window";
}

public class ShopIcon : BaseIcon
{
    protected override string IconSource => "shop";
}

public class ShuffleIcon : BaseIcon
{
    protected override string IconSource => "shuffle";
}

public class Signpost2FillIcon : BaseIcon
{
    protected override string IconSource => "signpost-2-fill";
}

public class Signpost2Icon : BaseIcon
{
    protected override string IconSource => "signpost-2";
}

public class SignpostFillIcon : BaseIcon
{
    protected override string IconSource => "signpost-fill";
}

public class SignpostSplitFillIcon : BaseIcon
{
    protected override string IconSource => "signpost-split-fill";
}

public class SignpostSplitIcon : BaseIcon
{
    protected override string IconSource => "signpost-split";
}

public class SignpostIcon : BaseIcon
{
    protected override string IconSource => "signpost";
}

public class SimFillIcon : BaseIcon
{
    protected override string IconSource => "sim-fill";
}

public class SimIcon : BaseIcon
{
    protected override string IconSource => "sim";
}

public class SkipBackwardBtnFillIcon : BaseIcon
{
    protected override string IconSource => "skip-backward-btn-fill";
}

public class SkipBackwardBtnIcon : BaseIcon
{
    protected override string IconSource => "skip-backward-btn";
}

public class SkipBackwardCircleFillIcon : BaseIcon
{
    protected override string IconSource => "skip-backward-circle-fill";
}

public class SkipBackwardCircleIcon : BaseIcon
{
    protected override string IconSource => "skip-backward-circle";
}

public class SkipBackwardFillIcon : BaseIcon
{
    protected override string IconSource => "skip-backward-fill";
}

public class SkipBackwardIcon : BaseIcon
{
    protected override string IconSource => "skip-backward";
}

public class SkipEndBtnFillIcon : BaseIcon
{
    protected override string IconSource => "skip-end-btn-fill";
}

public class SkipEndBtnIcon : BaseIcon
{
    protected override string IconSource => "skip-end-btn";
}

public class SkipEndCircleFillIcon : BaseIcon
{
    protected override string IconSource => "skip-end-circle-fill";
}

public class SkipEndCircleIcon : BaseIcon
{
    protected override string IconSource => "skip-end-circle";
}

public class SkipEndFillIcon : BaseIcon
{
    protected override string IconSource => "skip-end-fill";
}

public class SkipEndIcon : BaseIcon
{
    protected override string IconSource => "skip-end";
}

public class SkipForwardBtnFillIcon : BaseIcon
{
    protected override string IconSource => "skip-forward-btn-fill";
}

public class SkipForwardBtnIcon : BaseIcon
{
    protected override string IconSource => "skip-forward-btn";
}

public class SkipForwardCircleFillIcon : BaseIcon
{
    protected override string IconSource => "skip-forward-circle-fill";
}

public class SkipForwardCircleIcon : BaseIcon
{
    protected override string IconSource => "skip-forward-circle";
}

public class SkipForwardFillIcon : BaseIcon
{
    protected override string IconSource => "skip-forward-fill";
}

public class SkipForwardIcon : BaseIcon
{
    protected override string IconSource => "skip-forward";
}

public class SkipStartBtnFillIcon : BaseIcon
{
    protected override string IconSource => "skip-start-btn-fill";
}

public class SkipStartBtnIcon : BaseIcon
{
    protected override string IconSource => "skip-start-btn";
}

public class SkipStartCircleFillIcon : BaseIcon
{
    protected override string IconSource => "skip-start-circle-fill";
}

public class SkipStartCircleIcon : BaseIcon
{
    protected override string IconSource => "skip-start-circle";
}

public class SkipStartFillIcon : BaseIcon
{
    protected override string IconSource => "skip-start-fill";
}

public class SkipStartIcon : BaseIcon
{
    protected override string IconSource => "skip-start";
}

public class SlackIcon : BaseIcon
{
    protected override string IconSource => "slack";
}

public class SlashCircleFillIcon : BaseIcon
{
    protected override string IconSource => "slash-circle-fill";
}

public class SlashCircleIcon : BaseIcon
{
    protected override string IconSource => "slash-circle";
}

public class SlashSquareFillIcon : BaseIcon
{
    protected override string IconSource => "slash-square-fill";
}

public class SlashSquareIcon : BaseIcon
{
    protected override string IconSource => "slash-square";
}

public class SlashIcon : BaseIcon
{
    protected override string IconSource => "slash";
}

public class SlidersIcon : BaseIcon
{
    protected override string IconSource => "sliders";
}

public class SmartwatchIcon : BaseIcon
{
    protected override string IconSource => "smartwatch";
}

public class SnowIcon : BaseIcon
{
    protected override string IconSource => "snow";
}

public class Snow2Icon : BaseIcon
{
    protected override string IconSource => "snow2";
}

public class Snow3Icon : BaseIcon
{
    protected override string IconSource => "snow3";
}

public class SortAlphaDownAltIcon : BaseIcon
{
    protected override string IconSource => "sort-alpha-down-alt";
}

public class SortAlphaDownIcon : BaseIcon
{
    protected override string IconSource => "sort-alpha-down";
}

public class SortAlphaUpAltIcon : BaseIcon
{
    protected override string IconSource => "sort-alpha-up-alt";
}

public class SortAlphaUpIcon : BaseIcon
{
    protected override string IconSource => "sort-alpha-up";
}

public class SortDownAltIcon : BaseIcon
{
    protected override string IconSource => "sort-down-alt";
}

public class SortDownIcon : BaseIcon
{
    protected override string IconSource => "sort-down";
}

public class SortNumericDownAltIcon : BaseIcon
{
    protected override string IconSource => "sort-numeric-down-alt";
}

public class SortNumericDownIcon : BaseIcon
{
    protected override string IconSource => "sort-numeric-down";
}

public class SortNumericUpAltIcon : BaseIcon
{
    protected override string IconSource => "sort-numeric-up-alt";
}

public class SortNumericUpIcon : BaseIcon
{
    protected override string IconSource => "sort-numeric-up";
}

public class SortUpAltIcon : BaseIcon
{
    protected override string IconSource => "sort-up-alt";
}

public class SortUpIcon : BaseIcon
{
    protected override string IconSource => "sort-up";
}

public class SoundwaveIcon : BaseIcon
{
    protected override string IconSource => "soundwave";
}

public class SpeakerFillIcon : BaseIcon
{
    protected override string IconSource => "speaker-fill";
}

public class SpeakerIcon : BaseIcon
{
    protected override string IconSource => "speaker";
}

public class SpeedometerIcon : BaseIcon
{
    protected override string IconSource => "speedometer";
}

public class Speedometer2Icon : BaseIcon
{
    protected override string IconSource => "speedometer2";
}

public class SpellcheckIcon : BaseIcon
{
    protected override string IconSource => "spellcheck";
}

public class SquareFillIcon : BaseIcon
{
    protected override string IconSource => "square-fill";
}

public class SquareHalfIcon : BaseIcon
{
    protected override string IconSource => "square-half";
}

public class SquareIcon : BaseIcon
{
    protected override string IconSource => "square";
}

public class StackIcon : BaseIcon
{
    protected override string IconSource => "stack";
}

public class StarFillIcon : BaseIcon
{
    protected override string IconSource => "star-fill";
}

public class StarHalfIcon : BaseIcon
{
    protected override string IconSource => "star-half";
}

public class StarIcon : BaseIcon
{
    protected override string IconSource => "star";
}

public class StarsIcon : BaseIcon
{
    protected override string IconSource => "stars";
}

public class StickiesFillIcon : BaseIcon
{
    protected override string IconSource => "stickies-fill";
}

public class StickiesIcon : BaseIcon
{
    protected override string IconSource => "stickies";
}

public class StickyFillIcon : BaseIcon
{
    protected override string IconSource => "sticky-fill";
}

public class StickyIcon : BaseIcon
{
    protected override string IconSource => "sticky";
}

public class StopBtnFillIcon : BaseIcon
{
    protected override string IconSource => "stop-btn-fill";
}

public class StopBtnIcon : BaseIcon
{
    protected override string IconSource => "stop-btn";
}

public class StopCircleFillIcon : BaseIcon
{
    protected override string IconSource => "stop-circle-fill";
}

public class StopCircleIcon : BaseIcon
{
    protected override string IconSource => "stop-circle";
}

public class StopFillIcon : BaseIcon
{
    protected override string IconSource => "stop-fill";
}

public class StopIcon : BaseIcon
{
    protected override string IconSource => "stop";
}

public class StoplightsFillIcon : BaseIcon
{
    protected override string IconSource => "stoplights-fill";
}

public class StoplightsIcon : BaseIcon
{
    protected override string IconSource => "stoplights";
}

public class StopwatchFillIcon : BaseIcon
{
    protected override string IconSource => "stopwatch-fill";
}

public class StopwatchIcon : BaseIcon
{
    protected override string IconSource => "stopwatch";
}

public class SubtractIcon : BaseIcon
{
    protected override string IconSource => "subtract";
}

public class SuitClubFillIcon : BaseIcon
{
    protected override string IconSource => "suit-club-fill";
}

public class SuitClubIcon : BaseIcon
{
    protected override string IconSource => "suit-club";
}

public class SuitDiamondFillIcon : BaseIcon
{
    protected override string IconSource => "suit-diamond-fill";
}

public class SuitDiamondIcon : BaseIcon
{
    protected override string IconSource => "suit-diamond";
}

public class SuitHeartFillIcon : BaseIcon
{
    protected override string IconSource => "suit-heart-fill";
}

public class SuitHeartIcon : BaseIcon
{
    protected override string IconSource => "suit-heart";
}

public class SuitSpadeFillIcon : BaseIcon
{
    protected override string IconSource => "suit-spade-fill";
}

public class SuitSpadeIcon : BaseIcon
{
    protected override string IconSource => "suit-spade";
}

public class SunFillIcon : BaseIcon
{
    protected override string IconSource => "sun-fill";
}

public class SunIcon : BaseIcon
{
    protected override string IconSource => "sun";
}

public class SunglassesIcon : BaseIcon
{
    protected override string IconSource => "sunglasses";
}

public class SunriseFillIcon : BaseIcon
{
    protected override string IconSource => "sunrise-fill";
}

public class SunriseIcon : BaseIcon
{
    protected override string IconSource => "sunrise";
}

public class SunsetFillIcon : BaseIcon
{
    protected override string IconSource => "sunset-fill";
}

public class SunsetIcon : BaseIcon
{
    protected override string IconSource => "sunset";
}

public class SymmetryHorizontalIcon : BaseIcon
{
    protected override string IconSource => "symmetry-horizontal";
}

public class SymmetryVerticalIcon : BaseIcon
{
    protected override string IconSource => "symmetry-vertical";
}

public class TableIcon : BaseIcon
{
    protected override string IconSource => "table";
}

public class TabletFillIcon : BaseIcon
{
    protected override string IconSource => "tablet-fill";
}

public class TabletLandscapeFillIcon : BaseIcon
{
    protected override string IconSource => "tablet-landscape-fill";
}

public class TabletLandscapeIcon : BaseIcon
{
    protected override string IconSource => "tablet-landscape";
}

public class TabletIcon : BaseIcon
{
    protected override string IconSource => "tablet";
}

public class TagFillIcon : BaseIcon
{
    protected override string IconSource => "tag-fill";
}

public class TagIcon : BaseIcon
{
    protected override string IconSource => "tag";
}

public class TagsFillIcon : BaseIcon
{
    protected override string IconSource => "tags-fill";
}

public class TagsIcon : BaseIcon
{
    protected override string IconSource => "tags";
}

public class TelegramIcon : BaseIcon
{
    protected override string IconSource => "telegram";
}

public class TelephoneFillIcon : BaseIcon
{
    protected override string IconSource => "telephone-fill";
}

public class TelephoneForwardFillIcon : BaseIcon
{
    protected override string IconSource => "telephone-forward-fill";
}

public class TelephoneForwardIcon : BaseIcon
{
    protected override string IconSource => "telephone-forward";
}

public class TelephoneInboundFillIcon : BaseIcon
{
    protected override string IconSource => "telephone-inbound-fill";
}

public class TelephoneInboundIcon : BaseIcon
{
    protected override string IconSource => "telephone-inbound";
}

public class TelephoneMinusFillIcon : BaseIcon
{
    protected override string IconSource => "telephone-minus-fill";
}

public class TelephoneMinusIcon : BaseIcon
{
    protected override string IconSource => "telephone-minus";
}

public class TelephoneOutboundFillIcon : BaseIcon
{
    protected override string IconSource => "telephone-outbound-fill";
}

public class TelephoneOutboundIcon : BaseIcon
{
    protected override string IconSource => "telephone-outbound";
}

public class TelephonePlusFillIcon : BaseIcon
{
    protected override string IconSource => "telephone-plus-fill";
}

public class TelephonePlusIcon : BaseIcon
{
    protected override string IconSource => "telephone-plus";
}

public class TelephoneXFillIcon : BaseIcon
{
    protected override string IconSource => "telephone-x-fill";
}

public class TelephoneXIcon : BaseIcon
{
    protected override string IconSource => "telephone-x";
}

public class TelephoneIcon : BaseIcon
{
    protected override string IconSource => "telephone";
}

public class TerminalFillIcon : BaseIcon
{
    protected override string IconSource => "terminal-fill";
}

public class TerminalIcon : BaseIcon
{
    protected override string IconSource => "terminal";
}

public class TextCenterIcon : BaseIcon
{
    protected override string IconSource => "text-center";
}

public class TextIndentLeftIcon : BaseIcon
{
    protected override string IconSource => "text-indent-left";
}

public class TextIndentRightIcon : BaseIcon
{
    protected override string IconSource => "text-indent-right";
}

public class TextLeftIcon : BaseIcon
{
    protected override string IconSource => "text-left";
}

public class TextParagraphIcon : BaseIcon
{
    protected override string IconSource => "text-paragraph";
}

public class TextRightIcon : BaseIcon
{
    protected override string IconSource => "text-right";
}

public class TextareaResizeIcon : BaseIcon
{
    protected override string IconSource => "textarea-resize";
}

public class TextareaTIcon : BaseIcon
{
    protected override string IconSource => "textarea-t";
}

public class TextareaIcon : BaseIcon
{
    protected override string IconSource => "textarea";
}

public class ThermometerHalfIcon : BaseIcon
{
    protected override string IconSource => "thermometer-half";
}

public class ThermometerHighIcon : BaseIcon
{
    protected override string IconSource => "thermometer-high";
}

public class ThermometerLowIcon : BaseIcon
{
    protected override string IconSource => "thermometer-low";
}

public class ThermometerSnowIcon : BaseIcon
{
    protected override string IconSource => "thermometer-snow";
}

public class ThermometerSunIcon : BaseIcon
{
    protected override string IconSource => "thermometer-sun";
}

public class ThermometerIcon : BaseIcon
{
    protected override string IconSource => "thermometer";
}

public class ThreeDotsVerticalIcon : BaseIcon
{
    protected override string IconSource => "three-dots-vertical";
}

public class ThreeDotsIcon : BaseIcon
{
    protected override string IconSource => "three-dots";
}

public class ToggleOffIcon : BaseIcon
{
    protected override string IconSource => "toggle-off";
}

public class ToggleOnIcon : BaseIcon
{
    protected override string IconSource => "toggle-on";
}

public class Toggle2OffIcon : BaseIcon
{
    protected override string IconSource => "toggle2-off";
}

public class Toggle2OnIcon : BaseIcon
{
    protected override string IconSource => "toggle2-on";
}

public class TogglesIcon : BaseIcon
{
    protected override string IconSource => "toggles";
}

public class Toggles2Icon : BaseIcon
{
    protected override string IconSource => "toggles2";
}

public class ToolsIcon : BaseIcon
{
    protected override string IconSource => "tools";
}

public class TornadoIcon : BaseIcon
{
    protected override string IconSource => "tornado";
}

public class TrashFillIcon : BaseIcon
{
    protected override string IconSource => "trash-fill";
}

public class TrashIcon : BaseIcon
{
    protected override string IconSource => "trash";
}

public class Trash2FillIcon : BaseIcon
{
    protected override string IconSource => "trash2-fill";
}

public class Trash2Icon : BaseIcon
{
    protected override string IconSource => "trash2";
}

public class TreeFillIcon : BaseIcon
{
    protected override string IconSource => "tree-fill";
}

public class TreeIcon : BaseIcon
{
    protected override string IconSource => "tree";
}

public class TriangleFillIcon : BaseIcon
{
    protected override string IconSource => "triangle-fill";
}

public class TriangleHalfIcon : BaseIcon
{
    protected override string IconSource => "triangle-half";
}

public class TriangleIcon : BaseIcon
{
    protected override string IconSource => "triangle";
}

public class TrophyFillIcon : BaseIcon
{
    protected override string IconSource => "trophy-fill";
}

public class TrophyIcon : BaseIcon
{
    protected override string IconSource => "trophy";
}

public class TropicalStormIcon : BaseIcon
{
    protected override string IconSource => "tropical-storm";
}

public class TruckFlatbedIcon : BaseIcon
{
    protected override string IconSource => "truck-flatbed";
}

public class TruckIcon : BaseIcon
{
    protected override string IconSource => "truck";
}

public class TsunamiIcon : BaseIcon
{
    protected override string IconSource => "tsunami";
}

public class TvFillIcon : BaseIcon
{
    protected override string IconSource => "tv-fill";
}

public class TvIcon : BaseIcon
{
    protected override string IconSource => "tv";
}

public class TwitchIcon : BaseIcon
{
    protected override string IconSource => "twitch";
}

public class TwitterIcon : BaseIcon
{
    protected override string IconSource => "twitter";
}

public class TypeBoldIcon : BaseIcon
{
    protected override string IconSource => "type-bold";
}

public class TypeH1Icon : BaseIcon
{
    protected override string IconSource => "type-h1";
}

public class TypeH2Icon : BaseIcon
{
    protected override string IconSource => "type-h2";
}

public class TypeH3Icon : BaseIcon
{
    protected override string IconSource => "type-h3";
}

public class TypeItalicIcon : BaseIcon
{
    protected override string IconSource => "type-italic";
}

public class TypeStrikethroughIcon : BaseIcon
{
    protected override string IconSource => "type-strikethrough";
}

public class TypeUnderlineIcon : BaseIcon
{
    protected override string IconSource => "type-underline";
}

public class TypeIcon : BaseIcon
{
    protected override string IconSource => "type";
}

public class UiChecksGridIcon : BaseIcon
{
    protected override string IconSource => "ui-checks-grid";
}

public class UiChecksIcon : BaseIcon
{
    protected override string IconSource => "ui-checks";
}

public class UiRadiosGridIcon : BaseIcon
{
    protected override string IconSource => "ui-radios-grid";
}

public class UiRadiosIcon : BaseIcon
{
    protected override string IconSource => "ui-radios";
}

public class UmbrellaFillIcon : BaseIcon
{
    protected override string IconSource => "umbrella-fill";
}

public class UmbrellaIcon : BaseIcon
{
    protected override string IconSource => "umbrella";
}

public class UnionIcon : BaseIcon
{
    protected override string IconSource => "union";
}

public class UnlockFillIcon : BaseIcon
{
    protected override string IconSource => "unlock-fill";
}

public class UnlockIcon : BaseIcon
{
    protected override string IconSource => "unlock";
}

public class UpcScanIcon : BaseIcon
{
    protected override string IconSource => "upc-scan";
}

public class UpcIcon : BaseIcon
{
    protected override string IconSource => "upc";
}

public class UploadIcon : BaseIcon
{
    protected override string IconSource => "upload";
}

public class VectorPenIcon : BaseIcon
{
    protected override string IconSource => "vector-pen";
}

public class ViewListIcon : BaseIcon
{
    protected override string IconSource => "view-list";
}

public class ViewStackedIcon : BaseIcon
{
    protected override string IconSource => "view-stacked";
}

public class VinylFillIcon : BaseIcon
{
    protected override string IconSource => "vinyl-fill";
}

public class VinylIcon : BaseIcon
{
    protected override string IconSource => "vinyl";
}

public class VoicemailIcon : BaseIcon
{
    protected override string IconSource => "voicemail";
}

public class VolumeDownFillIcon : BaseIcon
{
    protected override string IconSource => "volume-down-fill";
}

public class VolumeDownIcon : BaseIcon
{
    protected override string IconSource => "volume-down";
}

public class VolumeMuteFillIcon : BaseIcon
{
    protected override string IconSource => "volume-mute-fill";
}

public class VolumeMuteIcon : BaseIcon
{
    protected override string IconSource => "volume-mute";
}

public class VolumeOffFillIcon : BaseIcon
{
    protected override string IconSource => "volume-off-fill";
}

public class VolumeOffIcon : BaseIcon
{
    protected override string IconSource => "volume-off";
}

public class VolumeUpFillIcon : BaseIcon
{
    protected override string IconSource => "volume-up-fill";
}

public class VolumeUpIcon : BaseIcon
{
    protected override string IconSource => "volume-up";
}

public class VrIcon : BaseIcon
{
    protected override string IconSource => "vr";
}

public class WalletFillIcon : BaseIcon
{
    protected override string IconSource => "wallet-fill";
}

public class WalletIcon : BaseIcon
{
    protected override string IconSource => "wallet";
}

public class Wallet2Icon : BaseIcon
{
    protected override string IconSource => "wallet2";
}

public class WatchIcon : BaseIcon
{
    protected override string IconSource => "watch";
}

public class WaterIcon : BaseIcon
{
    protected override string IconSource => "water";
}

public class WhatsappIcon : BaseIcon
{
    protected override string IconSource => "whatsapp";
}

public class Wifi1Icon : BaseIcon
{
    protected override string IconSource => "wifi-1";
}

public class Wifi2Icon : BaseIcon
{
    protected override string IconSource => "wifi-2";
}

public class WifiOffIcon : BaseIcon
{
    protected override string IconSource => "wifi-off";
}

public class WifiIcon : BaseIcon
{
    protected override string IconSource => "wifi";
}

public class WindIcon : BaseIcon
{
    protected override string IconSource => "wind";
}

public class WindowDockIcon : BaseIcon
{
    protected override string IconSource => "window-dock";
}

public class WindowSidebarIcon : BaseIcon
{
    protected override string IconSource => "window-sidebar";
}

public class WindowIcon : BaseIcon
{
    protected override string IconSource => "window";
}

public class WrenchIcon : BaseIcon
{
    protected override string IconSource => "wrench";
}

public class XCircleFillIcon : BaseIcon
{
    protected override string IconSource => "x-circle-fill";
}

public class XCircleIcon : BaseIcon
{
    protected override string IconSource => "x-circle";
}

public class XDiamondFillIcon : BaseIcon
{
    protected override string IconSource => "x-diamond-fill";
}

public class XDiamondIcon : BaseIcon
{
    protected override string IconSource => "x-diamond";
}

public class XOctagonFillIcon : BaseIcon
{
    protected override string IconSource => "x-octagon-fill";
}

public class XOctagonIcon : BaseIcon
{
    protected override string IconSource => "x-octagon";
}

public class XSquareFillIcon : BaseIcon
{
    protected override string IconSource => "x-square-fill";
}

public class XSquareIcon : BaseIcon
{
    protected override string IconSource => "x-square";
}

public class XIcon : BaseIcon
{
    protected override string IconSource => "x";
}

public class YoutubeIcon : BaseIcon
{
    protected override string IconSource => "youtube";
}

public class ZoomInIcon : BaseIcon
{
    protected override string IconSource => "zoom-in";
}

public class ZoomOutIcon : BaseIcon
{
    protected override string IconSource => "zoom-out";
}

public class BankIcon : BaseIcon
{
    protected override string IconSource => "bank";
}

public class Bank2Icon : BaseIcon
{
    protected override string IconSource => "bank2";
}

public class BellSlashFillIcon : BaseIcon
{
    protected override string IconSource => "bell-slash-fill";
}

public class BellSlashIcon : BaseIcon
{
    protected override string IconSource => "bell-slash";
}

public class CashCoinIcon : BaseIcon
{
    protected override string IconSource => "cash-coin";
}

public class CheckLgIcon : BaseIcon
{
    protected override string IconSource => "check-lg";
}

public class CoinIcon : BaseIcon
{
    protected override string IconSource => "coin";
}

public class CurrencyBitcoinIcon : BaseIcon
{
    protected override string IconSource => "currency-bitcoin";
}

public class CurrencyDollarIcon : BaseIcon
{
    protected override string IconSource => "currency-dollar";
}

public class CurrencyEuroIcon : BaseIcon
{
    protected override string IconSource => "currency-euro";
}

public class CurrencyExchangeIcon : BaseIcon
{
    protected override string IconSource => "currency-exchange";
}

public class CurrencyPoundIcon : BaseIcon
{
    protected override string IconSource => "currency-pound";
}

public class CurrencyYenIcon : BaseIcon
{
    protected override string IconSource => "currency-yen";
}

public class DashLgIcon : BaseIcon
{
    protected override string IconSource => "dash-lg";
}

public class ExclamationLgIcon : BaseIcon
{
    protected override string IconSource => "exclamation-lg";
}

public class FileEarmarkPdfFillIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-pdf-fill";
}

public class FileEarmarkPdfIcon : BaseIcon
{
    protected override string IconSource => "file-earmark-pdf";
}

public class FilePdfFillIcon : BaseIcon
{
    protected override string IconSource => "file-pdf-fill";
}

public class FilePdfIcon : BaseIcon
{
    protected override string IconSource => "file-pdf";
}

public class GenderAmbiguousIcon : BaseIcon
{
    protected override string IconSource => "gender-ambiguous";
}

public class GenderFemaleIcon : BaseIcon
{
    protected override string IconSource => "gender-female";
}

public class GenderMaleIcon : BaseIcon
{
    protected override string IconSource => "gender-male";
}

public class GenderTransIcon : BaseIcon
{
    protected override string IconSource => "gender-trans";
}

public class HeadsetVrIcon : BaseIcon
{
    protected override string IconSource => "headset-vr";
}

public class InfoLgIcon : BaseIcon
{
    protected override string IconSource => "info-lg";
}

public class MastodonIcon : BaseIcon
{
    protected override string IconSource => "mastodon";
}

public class MessengerIcon : BaseIcon
{
    protected override string IconSource => "messenger";
}

public class PiggyBankFillIcon : BaseIcon
{
    protected override string IconSource => "piggy-bank-fill";
}

public class PiggyBankIcon : BaseIcon
{
    protected override string IconSource => "piggy-bank";
}

public class PinMapFillIcon : BaseIcon
{
    protected override string IconSource => "pin-map-fill";
}

public class PinMapIcon : BaseIcon
{
    protected override string IconSource => "pin-map";
}

public class PlusLgIcon : BaseIcon
{
    protected override string IconSource => "plus-lg";
}

public class QuestionLgIcon : BaseIcon
{
    protected override string IconSource => "question-lg";
}

public class RecycleIcon : BaseIcon
{
    protected override string IconSource => "recycle";
}

public class RedditIcon : BaseIcon
{
    protected override string IconSource => "reddit";
}

public class SafeFillIcon : BaseIcon
{
    protected override string IconSource => "safe-fill";
}

public class Safe2FillIcon : BaseIcon
{
    protected override string IconSource => "safe2-fill";
}

public class Safe2Icon : BaseIcon
{
    protected override string IconSource => "safe2";
}

public class SdCardFillIcon : BaseIcon
{
    protected override string IconSource => "sd-card-fill";
}

public class SdCardIcon : BaseIcon
{
    protected override string IconSource => "sd-card";
}

public class SkypeIcon : BaseIcon
{
    protected override string IconSource => "skype";
}

public class SlashLgIcon : BaseIcon
{
    protected override string IconSource => "slash-lg";
}

public class TranslateIcon : BaseIcon
{
    protected override string IconSource => "translate";
}

public class XLgIcon : BaseIcon
{
    protected override string IconSource => "x-lg";
}

public class SafeIcon : BaseIcon
{
    protected override string IconSource => "safe";
}

public class AppleIcon : BaseIcon
{
    protected override string IconSource => "apple";
}

public class MicrosoftIcon : BaseIcon
{
    protected override string IconSource => "microsoft";
}

public class WindowsIcon : BaseIcon
{
    protected override string IconSource => "windows";
}

public class BehanceIcon : BaseIcon
{
    protected override string IconSource => "behance";
}

public class DribbbleIcon : BaseIcon
{
    protected override string IconSource => "dribbble";
}

public class LineIcon : BaseIcon
{
    protected override string IconSource => "line";
}

public class MediumIcon : BaseIcon
{
    protected override string IconSource => "medium";
}

public class PaypalIcon : BaseIcon
{
    protected override string IconSource => "paypal";
}

public class PinterestIcon : BaseIcon
{
    protected override string IconSource => "pinterest";
}

public class SignalIcon : BaseIcon
{
    protected override string IconSource => "signal";
}

public class SnapchatIcon : BaseIcon
{
    protected override string IconSource => "snapchat";
}

public class SpotifyIcon : BaseIcon
{
    protected override string IconSource => "spotify";
}

public class StackOverflowIcon : BaseIcon
{
    protected override string IconSource => "stack-overflow";
}

public class StravaIcon : BaseIcon
{
    protected override string IconSource => "strava";
}

public class WordpressIcon : BaseIcon
{
    protected override string IconSource => "wordpress";
}

public class VimeoIcon : BaseIcon
{
    protected override string IconSource => "vimeo";
}

public class ActivityIcon : BaseIcon
{
    protected override string IconSource => "activity";
}

public class Easel2FillIcon : BaseIcon
{
    protected override string IconSource => "easel2-fill";
}

public class Easel2Icon : BaseIcon
{
    protected override string IconSource => "easel2";
}

public class Easel3FillIcon : BaseIcon
{
    protected override string IconSource => "easel3-fill";
}

public class Easel3Icon : BaseIcon
{
    protected override string IconSource => "easel3";
}

public class FanIcon : BaseIcon
{
    protected override string IconSource => "fan";
}

public class FingerprintIcon : BaseIcon
{
    protected override string IconSource => "fingerprint";
}

public class GraphDownArrowIcon : BaseIcon
{
    protected override string IconSource => "graph-down-arrow";
}

public class GraphUpArrowIcon : BaseIcon
{
    protected override string IconSource => "graph-up-arrow";
}

public class HypnotizeIcon : BaseIcon
{
    protected override string IconSource => "hypnotize";
}

public class MagicIcon : BaseIcon
{
    protected override string IconSource => "magic";
}

public class PersonRolodexIcon : BaseIcon
{
    protected override string IconSource => "person-rolodex";
}

public class PersonVideoIcon : BaseIcon
{
    protected override string IconSource => "person-video";
}

public class PersonVideo2Icon : BaseIcon
{
    protected override string IconSource => "person-video2";
}

public class PersonVideo3Icon : BaseIcon
{
    protected override string IconSource => "person-video3";
}

public class PersonWorkspaceIcon : BaseIcon
{
    protected override string IconSource => "person-workspace";
}

public class RadioactiveIcon : BaseIcon
{
    protected override string IconSource => "radioactive";
}

public class WebcamFillIcon : BaseIcon
{
    protected override string IconSource => "webcam-fill";
}

public class WebcamIcon : BaseIcon
{
    protected override string IconSource => "webcam";
}

public class YinYangIcon : BaseIcon
{
    protected override string IconSource => "yin-yang";
}

public class BandaidFillIcon : BaseIcon
{
    protected override string IconSource => "bandaid-fill";
}

public class BandaidIcon : BaseIcon
{
    protected override string IconSource => "bandaid";
}

public class BluetoothIcon : BaseIcon
{
    protected override string IconSource => "bluetooth";
}

public class BodyTextIcon : BaseIcon
{
    protected override string IconSource => "body-text";
}

public class BoomboxIcon : BaseIcon
{
    protected override string IconSource => "boombox";
}

public class BoxesIcon : BaseIcon
{
    protected override string IconSource => "boxes";
}

public class DpadFillIcon : BaseIcon
{
    protected override string IconSource => "dpad-fill";
}

public class DpadIcon : BaseIcon
{
    protected override string IconSource => "dpad";
}

public class EarFillIcon : BaseIcon
{
    protected override string IconSource => "ear-fill";
}

public class EarIcon : BaseIcon
{
    protected override string IconSource => "ear";
}

public class EnvelopeCheck1Icon : BaseIcon
{
    protected override string IconSource => "envelope-check-1";
}

public class EnvelopeCheckFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-check-fill";
}

public class EnvelopeCheckIcon : BaseIcon
{
    protected override string IconSource => "envelope-check";
}

public class EnvelopeDash1Icon : BaseIcon
{
    protected override string IconSource => "envelope-dash-1";
}

public class EnvelopeDashFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-dash-fill";
}

public class EnvelopeDashIcon : BaseIcon
{
    protected override string IconSource => "envelope-dash";
}

public class EnvelopeExclamation1Icon : BaseIcon
{
    protected override string IconSource => "envelope-exclamation-1";
}

public class EnvelopeExclamationFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-exclamation-fill";
}

public class EnvelopeExclamationIcon : BaseIcon
{
    protected override string IconSource => "envelope-exclamation";
}

public class EnvelopePlusFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-plus-fill";
}

public class EnvelopePlusIcon : BaseIcon
{
    protected override string IconSource => "envelope-plus";
}

public class EnvelopeSlash1Icon : BaseIcon
{
    protected override string IconSource => "envelope-slash-1";
}

public class EnvelopeSlashFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-slash-fill";
}

public class EnvelopeSlashIcon : BaseIcon
{
    protected override string IconSource => "envelope-slash";
}

public class EnvelopeX1Icon : BaseIcon
{
    protected override string IconSource => "envelope-x-1";
}

public class EnvelopeXFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-x-fill";
}

public class EnvelopeXIcon : BaseIcon
{
    protected override string IconSource => "envelope-x";
}

public class ExplicitFillIcon : BaseIcon
{
    protected override string IconSource => "explicit-fill";
}

public class ExplicitIcon : BaseIcon
{
    protected override string IconSource => "explicit";
}

public class GitIcon : BaseIcon
{
    protected override string IconSource => "git";
}

public class InfinityIcon : BaseIcon
{
    protected override string IconSource => "infinity";
}

public class ListColumnsReverseIcon : BaseIcon
{
    protected override string IconSource => "list-columns-reverse";
}

public class ListColumnsIcon : BaseIcon
{
    protected override string IconSource => "list-columns";
}

public class MetaIcon : BaseIcon
{
    protected override string IconSource => "meta";
}

public class MortorboardFillIcon : BaseIcon
{
    protected override string IconSource => "mortorboard-fill";
}

public class MortorboardIcon : BaseIcon
{
    protected override string IconSource => "mortorboard";
}

public class NintendoSwitchIcon : BaseIcon
{
    protected override string IconSource => "nintendo-switch";
}

public class PcDisplayHorizontalIcon : BaseIcon
{
    protected override string IconSource => "pc-display-horizontal";
}

public class PcDisplayIcon : BaseIcon
{
    protected override string IconSource => "pc-display";
}

public class PcHorizontalIcon : BaseIcon
{
    protected override string IconSource => "pc-horizontal";
}

public class PcIcon : BaseIcon
{
    protected override string IconSource => "pc";
}

public class PlaystationIcon : BaseIcon
{
    protected override string IconSource => "playstation";
}

public class PlusSlashMinusIcon : BaseIcon
{
    protected override string IconSource => "plus-slash-minus";
}

public class ProjectorFillIcon : BaseIcon
{
    protected override string IconSource => "projector-fill";
}

public class ProjectorIcon : BaseIcon
{
    protected override string IconSource => "projector";
}

public class QrCodeScanIcon : BaseIcon
{
    protected override string IconSource => "qr-code-scan";
}

public class QrCodeIcon : BaseIcon
{
    protected override string IconSource => "qr-code";
}

public class QuoraIcon : BaseIcon
{
    protected override string IconSource => "quora";
}

public class QuoteIcon : BaseIcon
{
    protected override string IconSource => "quote";
}

public class RobotIcon : BaseIcon
{
    protected override string IconSource => "robot";
}

public class SendCheckFillIcon : BaseIcon
{
    protected override string IconSource => "send-check-fill";
}

public class SendCheckIcon : BaseIcon
{
    protected override string IconSource => "send-check";
}

public class SendDashFillIcon : BaseIcon
{
    protected override string IconSource => "send-dash-fill";
}

public class SendDashIcon : BaseIcon
{
    protected override string IconSource => "send-dash";
}

public class SendExclamation1Icon : BaseIcon
{
    protected override string IconSource => "send-exclamation-1";
}

public class SendExclamationFillIcon : BaseIcon
{
    protected override string IconSource => "send-exclamation-fill";
}

public class SendExclamationIcon : BaseIcon
{
    protected override string IconSource => "send-exclamation";
}

public class SendFillIcon : BaseIcon
{
    protected override string IconSource => "send-fill";
}

public class SendPlusFillIcon : BaseIcon
{
    protected override string IconSource => "send-plus-fill";
}

public class SendPlusIcon : BaseIcon
{
    protected override string IconSource => "send-plus";
}

public class SendSlashFillIcon : BaseIcon
{
    protected override string IconSource => "send-slash-fill";
}

public class SendSlashIcon : BaseIcon
{
    protected override string IconSource => "send-slash";
}

public class SendXFillIcon : BaseIcon
{
    protected override string IconSource => "send-x-fill";
}

public class SendXIcon : BaseIcon
{
    protected override string IconSource => "send-x";
}

public class SendIcon : BaseIcon
{
    protected override string IconSource => "send";
}

public class SteamIcon : BaseIcon
{
    protected override string IconSource => "steam";
}

public class TerminalDash1Icon : BaseIcon
{
    protected override string IconSource => "terminal-dash-1";
}

public class TerminalDashIcon : BaseIcon
{
    protected override string IconSource => "terminal-dash";
}

public class TerminalPlusIcon : BaseIcon
{
    protected override string IconSource => "terminal-plus";
}

public class TerminalSplitIcon : BaseIcon
{
    protected override string IconSource => "terminal-split";
}

public class TicketDetailedFillIcon : BaseIcon
{
    protected override string IconSource => "ticket-detailed-fill";
}

public class TicketDetailedIcon : BaseIcon
{
    protected override string IconSource => "ticket-detailed";
}

public class TicketFillIcon : BaseIcon
{
    protected override string IconSource => "ticket-fill";
}

public class TicketPerforatedFillIcon : BaseIcon
{
    protected override string IconSource => "ticket-perforated-fill";
}

public class TicketPerforatedIcon : BaseIcon
{
    protected override string IconSource => "ticket-perforated";
}

public class TicketIcon : BaseIcon
{
    protected override string IconSource => "ticket";
}

public class TiktokIcon : BaseIcon
{
    protected override string IconSource => "tiktok";
}

public class WindowDashIcon : BaseIcon
{
    protected override string IconSource => "window-dash";
}

public class WindowDesktopIcon : BaseIcon
{
    protected override string IconSource => "window-desktop";
}

public class WindowFullscreenIcon : BaseIcon
{
    protected override string IconSource => "window-fullscreen";
}

public class WindowPlusIcon : BaseIcon
{
    protected override string IconSource => "window-plus";
}

public class WindowSplitIcon : BaseIcon
{
    protected override string IconSource => "window-split";
}

public class WindowStackIcon : BaseIcon
{
    protected override string IconSource => "window-stack";
}

public class WindowXIcon : BaseIcon
{
    protected override string IconSource => "window-x";
}

public class XboxIcon : BaseIcon
{
    protected override string IconSource => "xbox";
}

public class EthernetIcon : BaseIcon
{
    protected override string IconSource => "ethernet";
}

public class HdmiFillIcon : BaseIcon
{
    protected override string IconSource => "hdmi-fill";
}

public class HdmiIcon : BaseIcon
{
    protected override string IconSource => "hdmi";
}

public class UsbCFillIcon : BaseIcon
{
    protected override string IconSource => "usb-c-fill";
}

public class UsbCIcon : BaseIcon
{
    protected override string IconSource => "usb-c";
}

public class UsbFillIcon : BaseIcon
{
    protected override string IconSource => "usb-fill";
}

public class UsbPlugFillIcon : BaseIcon
{
    protected override string IconSource => "usb-plug-fill";
}

public class UsbPlugIcon : BaseIcon
{
    protected override string IconSource => "usb-plug";
}

public class UsbSymbolIcon : BaseIcon
{
    protected override string IconSource => "usb-symbol";
}

public class UsbIcon : BaseIcon
{
    protected override string IconSource => "usb";
}

public class BoomboxFillIcon : BaseIcon
{
    protected override string IconSource => "boombox-fill";
}

public class Displayport1Icon : BaseIcon
{
    protected override string IconSource => "displayport-1";
}

public class DisplayportIcon : BaseIcon
{
    protected override string IconSource => "displayport";
}

public class GpuCardIcon : BaseIcon
{
    protected override string IconSource => "gpu-card";
}

public class MemoryIcon : BaseIcon
{
    protected override string IconSource => "memory";
}

public class ModemFillIcon : BaseIcon
{
    protected override string IconSource => "modem-fill";
}

public class ModemIcon : BaseIcon
{
    protected override string IconSource => "modem";
}

public class MotherboardFillIcon : BaseIcon
{
    protected override string IconSource => "motherboard-fill";
}

public class MotherboardIcon : BaseIcon
{
    protected override string IconSource => "motherboard";
}

public class OpticalAudioFillIcon : BaseIcon
{
    protected override string IconSource => "optical-audio-fill";
}

public class OpticalAudioIcon : BaseIcon
{
    protected override string IconSource => "optical-audio";
}

public class PciCardIcon : BaseIcon
{
    protected override string IconSource => "pci-card";
}

public class RouterFillIcon : BaseIcon
{
    protected override string IconSource => "router-fill";
}

public class RouterIcon : BaseIcon
{
    protected override string IconSource => "router";
}

public class SsdFillIcon : BaseIcon
{
    protected override string IconSource => "ssd-fill";
}

public class SsdIcon : BaseIcon
{
    protected override string IconSource => "ssd";
}

public class ThunderboltFillIcon : BaseIcon
{
    protected override string IconSource => "thunderbolt-fill";
}

public class ThunderboltIcon : BaseIcon
{
    protected override string IconSource => "thunderbolt";
}

public class UsbDriveFillIcon : BaseIcon
{
    protected override string IconSource => "usb-drive-fill";
}

public class UsbDriveIcon : BaseIcon
{
    protected override string IconSource => "usb-drive";
}

public class UsbMicroFillIcon : BaseIcon
{
    protected override string IconSource => "usb-micro-fill";
}

public class UsbMicroIcon : BaseIcon
{
    protected override string IconSource => "usb-micro";
}

public class UsbMiniFillIcon : BaseIcon
{
    protected override string IconSource => "usb-mini-fill";
}

public class UsbMiniIcon : BaseIcon
{
    protected override string IconSource => "usb-mini";
}

public class CloudHaze2Icon : BaseIcon
{
    protected override string IconSource => "cloud-haze2";
}

public class DeviceHddFillIcon : BaseIcon
{
    protected override string IconSource => "device-hdd-fill";
}

public class DeviceHddIcon : BaseIcon
{
    protected override string IconSource => "device-hdd";
}

public class DeviceSsdFillIcon : BaseIcon
{
    protected override string IconSource => "device-ssd-fill";
}

public class DeviceSsdIcon : BaseIcon
{
    protected override string IconSource => "device-ssd";
}

public class DisplayportFillIcon : BaseIcon
{
    protected override string IconSource => "displayport-fill";
}

public class MortarboardFillIcon : BaseIcon
{
    protected override string IconSource => "mortarboard-fill";
}

public class MortarboardIcon : BaseIcon
{
    protected override string IconSource => "mortarboard";
}

public class TerminalXIcon : BaseIcon
{
    protected override string IconSource => "terminal-x";
}

public class ArrowThroughHeartFillIcon : BaseIcon
{
    protected override string IconSource => "arrow-through-heart-fill";
}

public class ArrowThroughHeartIcon : BaseIcon
{
    protected override string IconSource => "arrow-through-heart";
}

public class BadgeSdFillIcon : BaseIcon
{
    protected override string IconSource => "badge-sd-fill";
}

public class BadgeSdIcon : BaseIcon
{
    protected override string IconSource => "badge-sd";
}

public class BagHeartFillIcon : BaseIcon
{
    protected override string IconSource => "bag-heart-fill";
}

public class BagHeartIcon : BaseIcon
{
    protected override string IconSource => "bag-heart";
}

public class BalloonFillIcon : BaseIcon
{
    protected override string IconSource => "balloon-fill";
}

public class BalloonHeartFillIcon : BaseIcon
{
    protected override string IconSource => "balloon-heart-fill";
}

public class BalloonHeartIcon : BaseIcon
{
    protected override string IconSource => "balloon-heart";
}

public class BalloonIcon : BaseIcon
{
    protected override string IconSource => "balloon";
}

public class Box2FillIcon : BaseIcon
{
    protected override string IconSource => "box2-fill";
}

public class Box2HeartFillIcon : BaseIcon
{
    protected override string IconSource => "box2-heart-fill";
}

public class Box2HeartIcon : BaseIcon
{
    protected override string IconSource => "box2-heart";
}

public class Box2Icon : BaseIcon
{
    protected override string IconSource => "box2";
}

public class BracesAsteriskIcon : BaseIcon
{
    protected override string IconSource => "braces-asterisk";
}

public class CalendarHeartFillIcon : BaseIcon
{
    protected override string IconSource => "calendar-heart-fill";
}

public class CalendarHeartIcon : BaseIcon
{
    protected override string IconSource => "calendar-heart";
}

public class Calendar2HeartFillIcon : BaseIcon
{
    protected override string IconSource => "calendar2-heart-fill";
}

public class Calendar2HeartIcon : BaseIcon
{
    protected override string IconSource => "calendar2-heart";
}

public class ChatHeartFillIcon : BaseIcon
{
    protected override string IconSource => "chat-heart-fill";
}

public class ChatHeartIcon : BaseIcon
{
    protected override string IconSource => "chat-heart";
}

public class ChatLeftHeartFillIcon : BaseIcon
{
    protected override string IconSource => "chat-left-heart-fill";
}

public class ChatLeftHeartIcon : BaseIcon
{
    protected override string IconSource => "chat-left-heart";
}

public class ChatRightHeartFillIcon : BaseIcon
{
    protected override string IconSource => "chat-right-heart-fill";
}

public class ChatRightHeartIcon : BaseIcon
{
    protected override string IconSource => "chat-right-heart";
}

public class ChatSquareHeartFillIcon : BaseIcon
{
    protected override string IconSource => "chat-square-heart-fill";
}

public class ChatSquareHeartIcon : BaseIcon
{
    protected override string IconSource => "chat-square-heart";
}

public class ClipboardCheckFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard-check-fill";
}

public class ClipboardDataFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard-data-fill";
}

public class ClipboardFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard-fill";
}

public class ClipboardHeartFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard-heart-fill";
}

public class ClipboardHeartIcon : BaseIcon
{
    protected override string IconSource => "clipboard-heart";
}

public class ClipboardMinusFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard-minus-fill";
}

public class ClipboardPlusFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard-plus-fill";
}

public class ClipboardPulseIcon : BaseIcon
{
    protected override string IconSource => "clipboard-pulse";
}

public class ClipboardXFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard-x-fill";
}

public class Clipboard2CheckFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-check-fill";
}

public class Clipboard2CheckIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-check";
}

public class Clipboard2DataFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-data-fill";
}

public class Clipboard2DataIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-data";
}

public class Clipboard2FillIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-fill";
}

public class Clipboard2HeartFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-heart-fill";
}

public class Clipboard2HeartIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-heart";
}

public class Clipboard2MinusFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-minus-fill";
}

public class Clipboard2MinusIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-minus";
}

public class Clipboard2PlusFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-plus-fill";
}

public class Clipboard2PlusIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-plus";
}

public class Clipboard2PulseFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-pulse-fill";
}

public class Clipboard2PulseIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-pulse";
}

public class Clipboard2XFillIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-x-fill";
}

public class Clipboard2XIcon : BaseIcon
{
    protected override string IconSource => "clipboard2-x";
}

public class Clipboard2Icon : BaseIcon
{
    protected override string IconSource => "clipboard2";
}

public class EmojiKissFillIcon : BaseIcon
{
    protected override string IconSource => "emoji-kiss-fill";
}

public class EmojiKissIcon : BaseIcon
{
    protected override string IconSource => "emoji-kiss";
}

public class EnvelopeHeartFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-heart-fill";
}

public class EnvelopeHeartIcon : BaseIcon
{
    protected override string IconSource => "envelope-heart";
}

public class EnvelopeOpenHeartFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-open-heart-fill";
}

public class EnvelopeOpenHeartIcon : BaseIcon
{
    protected override string IconSource => "envelope-open-heart";
}

public class EnvelopePaperFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-paper-fill";
}

public class EnvelopePaperHeartFillIcon : BaseIcon
{
    protected override string IconSource => "envelope-paper-heart-fill";
}

public class EnvelopePaperHeartIcon : BaseIcon
{
    protected override string IconSource => "envelope-paper-heart";
}

public class EnvelopePaperIcon : BaseIcon
{
    protected override string IconSource => "envelope-paper";
}

public class FiletypeAacIcon : BaseIcon
{
    protected override string IconSource => "filetype-aac";
}

public class FiletypeAiIcon : BaseIcon
{
    protected override string IconSource => "filetype-ai";
}

public class FiletypeBmpIcon : BaseIcon
{
    protected override string IconSource => "filetype-bmp";
}

public class FiletypeCsIcon : BaseIcon
{
    protected override string IconSource => "filetype-cs";
}

public class FiletypeCssIcon : BaseIcon
{
    protected override string IconSource => "filetype-css";
}

public class FiletypeCsvIcon : BaseIcon
{
    protected override string IconSource => "filetype-csv";
}

public class FiletypeDocIcon : BaseIcon
{
    protected override string IconSource => "filetype-doc";
}

public class FiletypeDocxIcon : BaseIcon
{
    protected override string IconSource => "filetype-docx";
}

public class FiletypeExeIcon : BaseIcon
{
    protected override string IconSource => "filetype-exe";
}

public class FiletypeGifIcon : BaseIcon
{
    protected override string IconSource => "filetype-gif";
}

public class FiletypeHeicIcon : BaseIcon
{
    protected override string IconSource => "filetype-heic";
}

public class FiletypeHtmlIcon : BaseIcon
{
    protected override string IconSource => "filetype-html";
}

public class FiletypeJavaIcon : BaseIcon
{
    protected override string IconSource => "filetype-java";
}

public class FiletypeJpgIcon : BaseIcon
{
    protected override string IconSource => "filetype-jpg";
}

public class FiletypeJsIcon : BaseIcon
{
    protected override string IconSource => "filetype-js";
}

public class FiletypeJsxIcon : BaseIcon
{
    protected override string IconSource => "filetype-jsx";
}

public class FiletypeKeyIcon : BaseIcon
{
    protected override string IconSource => "filetype-key";
}

public class FiletypeM4pIcon : BaseIcon
{
    protected override string IconSource => "filetype-m4p";
}

public class FiletypeMdIcon : BaseIcon
{
    protected override string IconSource => "filetype-md";
}

public class FiletypeMdxIcon : BaseIcon
{
    protected override string IconSource => "filetype-mdx";
}

public class FiletypeMovIcon : BaseIcon
{
    protected override string IconSource => "filetype-mov";
}

public class FiletypeMp3Icon : BaseIcon
{
    protected override string IconSource => "filetype-mp3";
}

public class FiletypeMp4Icon : BaseIcon
{
    protected override string IconSource => "filetype-mp4";
}

public class FiletypeOtfIcon : BaseIcon
{
    protected override string IconSource => "filetype-otf";
}

public class FiletypePdfIcon : BaseIcon
{
    protected override string IconSource => "filetype-pdf";
}

public class FiletypePhpIcon : BaseIcon
{
    protected override string IconSource => "filetype-php";
}

public class FiletypePngIcon : BaseIcon
{
    protected override string IconSource => "filetype-png";
}

public class FiletypePpt1Icon : BaseIcon
{
    protected override string IconSource => "filetype-ppt-1";
}

public class FiletypePptIcon : BaseIcon
{
    protected override string IconSource => "filetype-ppt";
}

public class FiletypePsdIcon : BaseIcon
{
    protected override string IconSource => "filetype-psd";
}

public class FiletypePyIcon : BaseIcon
{
    protected override string IconSource => "filetype-py";
}

public class FiletypeRawIcon : BaseIcon
{
    protected override string IconSource => "filetype-raw";
}

public class FiletypeRbIcon : BaseIcon
{
    protected override string IconSource => "filetype-rb";
}

public class FiletypeSassIcon : BaseIcon
{
    protected override string IconSource => "filetype-sass";
}

public class FiletypeScssIcon : BaseIcon
{
    protected override string IconSource => "filetype-scss";
}

public class FiletypeShIcon : BaseIcon
{
    protected override string IconSource => "filetype-sh";
}

public class FiletypeSvgIcon : BaseIcon
{
    protected override string IconSource => "filetype-svg";
}

public class FiletypeTiffIcon : BaseIcon
{
    protected override string IconSource => "filetype-tiff";
}

public class FiletypeTsxIcon : BaseIcon
{
    protected override string IconSource => "filetype-tsx";
}

public class FiletypeTtfIcon : BaseIcon
{
    protected override string IconSource => "filetype-ttf";
}

public class FiletypeTxtIcon : BaseIcon
{
    protected override string IconSource => "filetype-txt";
}

public class FiletypeWavIcon : BaseIcon
{
    protected override string IconSource => "filetype-wav";
}

public class FiletypeWoffIcon : BaseIcon
{
    protected override string IconSource => "filetype-woff";
}

public class FiletypeXls1Icon : BaseIcon
{
    protected override string IconSource => "filetype-xls-1";
}

public class FiletypeXlsIcon : BaseIcon
{
    protected override string IconSource => "filetype-xls";
}

public class FiletypeXmlIcon : BaseIcon
{
    protected override string IconSource => "filetype-xml";
}

public class FiletypeYmlIcon : BaseIcon
{
    protected override string IconSource => "filetype-yml";
}

public class HeartArrowIcon : BaseIcon
{
    protected override string IconSource => "heart-arrow";
}

public class HeartPulseFillIcon : BaseIcon
{
    protected override string IconSource => "heart-pulse-fill";
}

public class HeartPulseIcon : BaseIcon
{
    protected override string IconSource => "heart-pulse";
}

public class HeartbreakFillIcon : BaseIcon
{
    protected override string IconSource => "heartbreak-fill";
}

public class HeartbreakIcon : BaseIcon
{
    protected override string IconSource => "heartbreak";
}

public class HeartsIcon : BaseIcon
{
    protected override string IconSource => "hearts";
}

public class HospitalFillIcon : BaseIcon
{
    protected override string IconSource => "hospital-fill";
}

public class HospitalIcon : BaseIcon
{
    protected override string IconSource => "hospital";
}

public class HouseHeartFillIcon : BaseIcon
{
    protected override string IconSource => "house-heart-fill";
}

public class HouseHeartIcon : BaseIcon
{
    protected override string IconSource => "house-heart";
}

public class IncognitoIcon : BaseIcon
{
    protected override string IconSource => "incognito";
}

public class MagnetFillIcon : BaseIcon
{
    protected override string IconSource => "magnet-fill";
}

public class MagnetIcon : BaseIcon
{
    protected override string IconSource => "magnet";
}

public class PersonHeartIcon : BaseIcon
{
    protected override string IconSource => "person-heart";
}

public class PersonHeartsIcon : BaseIcon
{
    protected override string IconSource => "person-hearts";
}

public class PhoneFlipIcon : BaseIcon
{
    protected override string IconSource => "phone-flip";
}

public class PluginIcon : BaseIcon
{
    protected override string IconSource => "plugin";
}

public class PostageFillIcon : BaseIcon
{
    protected override string IconSource => "postage-fill";
}

public class PostageHeartFillIcon : BaseIcon
{
    protected override string IconSource => "postage-heart-fill";
}

public class PostageHeartIcon : BaseIcon
{
    protected override string IconSource => "postage-heart";
}

public class PostageIcon : BaseIcon
{
    protected override string IconSource => "postage";
}

public class PostcardFillIcon : BaseIcon
{
    protected override string IconSource => "postcard-fill";
}

public class PostcardHeartFillIcon : BaseIcon
{
    protected override string IconSource => "postcard-heart-fill";
}

public class PostcardHeartIcon : BaseIcon
{
    protected override string IconSource => "postcard-heart";
}

public class PostcardIcon : BaseIcon
{
    protected override string IconSource => "postcard";
}

public class SearchHeartFillIcon : BaseIcon
{
    protected override string IconSource => "search-heart-fill";
}

public class SearchHeartIcon : BaseIcon
{
    protected override string IconSource => "search-heart";
}

public class Sliders2VerticalIcon : BaseIcon
{
    protected override string IconSource => "sliders2-vertical";
}

public class Sliders2Icon : BaseIcon
{
    protected override string IconSource => "sliders2";
}

public class Trash3FillIcon : BaseIcon
{
    protected override string IconSource => "trash3-fill";
}

public class Trash3Icon : BaseIcon
{
    protected override string IconSource => "trash3";
}

public class ValentineIcon : BaseIcon
{
    protected override string IconSource => "valentine";
}

public class Valentine2Icon : BaseIcon
{
    protected override string IconSource => "valentine2";
}

public class WrenchAdjustableCircleFillIcon : BaseIcon
{
    protected override string IconSource => "wrench-adjustable-circle-fill";
}

public class WrenchAdjustableCircleIcon : BaseIcon
{
    protected override string IconSource => "wrench-adjustable-circle";
}

public class WrenchAdjustableIcon : BaseIcon
{
    protected override string IconSource => "wrench-adjustable";
}

public class FiletypeJsonIcon : BaseIcon
{
    protected override string IconSource => "filetype-json";
}

public class FiletypePptxIcon : BaseIcon
{
    protected override string IconSource => "filetype-pptx";
}

public class FiletypeXlsxIcon : BaseIcon
{
    protected override string IconSource => "filetype-xlsx";
}
