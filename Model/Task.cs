namespace APRApi.Model
{
    public class Task
    {
        /// <summary>
        /// Task unique identifier
        /// </summary>
        public string? Id;
        /// <summary>
        /// createTask
        /// </summary>
        public string? Name;
        /// <summary>
        /// http://ip:port/rpc/createTask
        /// </summary>
        public string? Path;
        /// <summary>
        /// The upper system calls this interface to create tasks
        /// </summary>
        public string? Description;
        /// <summary>
        /// HTTP/POST
        /// </summary>
        public string? Protocol;
        public string? Provider;
        /// <summary>
        /// The upper system
        /// </summary>
        public string? Caller;
    };

    /// <summary>
    /// CREATE TASK
    /// </summary>
    public class CreateRequest()
    {
        required public string? TaskId;

        required public string[] Targets;

        public string? ConfigId;

        public int Priority;
    }

    /// <summary>
    /// CREATE TASK
    /// </summary>
    public class CreateResponse()
    {
        public int? code;

        public string? msg;
    }


    /// <summary>
    /// CONTINUE TASK
    /// </summary>
    public class ContinueRequest()
    {
        public string? TaskId;
    }

    /// <summary>
    /// CONTINUE TASK
    /// </summary>
    public class ContinueResponse()
    {
        required public int Code;

        required public string Msg;
    }

    /// <summary>
    /// CANCEL TASK
    /// </summary>
    public class CancelRequest()
    {
        public string? TaskId;
    }

    /// <summary>
    /// CANCEL TASK
    /// </summary>
    public class CancelResponse()
    {
        required public int Code;

        required public string Msg;
    }

    //GET ONLINE ROBOT INFO
    public class GetInfoResponse()
    {
        required public int Code;

        required public string Msg;

        public List<Notes>? Data;
    }

    /// <summary>
    /// The data in the field data is an array of real-time data for all APRs, each containing the following basic data
    /// </summary>
    public class Notes
    {
        /// <summary>
        /// APR unique number
        /// </summary>
        public required string Id;

        public int X; // mm
        public int Y; // mm
        public int Z; // mm
        public int Theta; //angle

    }


    /// GET MAP INFO
    
    public class MapInfoRequest
    {

    }

    public class MapInfoResponse
    {
        public string? Mapname; 
    }


}
