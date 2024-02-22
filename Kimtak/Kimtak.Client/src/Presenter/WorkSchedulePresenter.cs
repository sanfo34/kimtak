using Kimtak.Client.Presenter;

namespace Kimtak.Client.Presenter
{
    /// <summary>
    /// 勤務情報
    /// </summary>
    /// <param name="date"></param>
    /// <param name="beginAt"></param>
    /// <param name="finishAt"></param>
    /// <param name="remarks"></param>
    public record Attendance(DateTime date, DateTime beginAt, DateTime finishAt, string remarks);

    public class WorkSchedulePresenter : IPresenter
    {
        private List<Attendance> attendanceList;

        public WorkSchedulePresenter()
        {
            attendanceList = new List<Attendance>();
        }
    }
}
