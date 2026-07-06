using System.ComponentModel.DataAnnotations;

namespace CleaningRequests.Models
{
    public class CleaningRequest
    {
        /// уникальный идентификатор заявки (первичный ключ таблицы)
        public int Id { get; set; }

        /// ФИО сотрудника, подавшего заявку
        [Required(ErrorMessage = "Укажите ФИО сотрудника")]
        [StringLength(100, ErrorMessage = "ФИО не может превышать 100 символов")]
        public string FullName { get; set; } = string.Empty;

        /// контактный номер телефона
        [Required(ErrorMessage = "Укажите контактный номер телефона")]
        [Phone(ErrorMessage = "Некорректный формат номера телефона")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// адрес офиса, в котором требуется уборка
        [Required(ErrorMessage = "Укажите адрес офиса")]
        public string OfficeAddress { get; set; } = string.Empty;

        /// номера кабинетов, которые нужно убрать
        [Required(ErrorMessage = "Укажите номера кабинетов")]
        public string Rooms { get; set; } = string.Empty;

        /// перечень необходимых услуг 
        [Required(ErrorMessage = "Выберите необходимые услуги")]
        public string Services { get; set; } = string.Empty;

        /// дата и время выполнения заявки
        [Required(ErrorMessage = "Укажите дату и время")]
        public DateTime RequestDateTime { get; set; }

        /// комментарий, который сотрудник может добавить при создании заявки
        public string? InitialComment { get; set; }

        /// текущий статус заявки 
        public RequestStatus Status { get; set; } = RequestStatus.InProgress;

        /// оценка качества уборки от 1 до 5
        [Range(1, 5, ErrorMessage = "Оценка должна быть от 1 до 5")]
        public int? Rating { get; set; }

        /// комментарий сотрудника к качеству уборки 
        public string? FeedbackComment { get; set; }
    }
}