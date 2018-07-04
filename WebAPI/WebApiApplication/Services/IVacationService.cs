namespace WebApiApplication.Services
{
    public interface IVacationService
    {
        void Approve(int vacationId);

        void Reject(int vacationId);
    }
}
