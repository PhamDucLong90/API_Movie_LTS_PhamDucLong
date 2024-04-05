namespace Project_XemPhim.PayLoad.Responses
{
    public class ResponseObject<T>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public T Data {  get; set; }
        public ResponseObject() { }
        public ResponseObject(int status, string message, T data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
        // tra ve doi tuong  responseObject khi request that bai
        public ResponseObject<T> ResponseFail(int status , string message,T data)
        {
            return new ResponseObject<T>(status, message, data);
        }
        // tra ve doi tuong resoinseObject khi request thanh cong
        public ResponseObject<T> ResponseSuccess(string message , T data)
        {
            return new ResponseObject<T>(200, message, data);
        }
    }
}
