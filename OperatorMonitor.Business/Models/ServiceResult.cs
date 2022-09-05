namespace OperatorMonitor.Business.Models
{
    public class ServiceResult<TModel>
      where TModel : class
    {
        public bool Response { get; set; }
        public string Message { get; set; }
        public TModel Data { get; set; }
    }
}
