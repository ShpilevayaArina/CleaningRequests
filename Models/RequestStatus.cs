namespace CleaningRequests.Models
{
    public enum RequestStatus
    {
        InProgress, // В работе (присваивается при создании заявки)
        Completed,  // Выполнено (подрядчик завершил уборку)
        Rated       // Оценено (сотрудник поставил оценку)
    }
}