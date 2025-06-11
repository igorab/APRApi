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
        /// <summary>
        /// 200 - Success Other - Failure
        /// </summary>
        required public int Code;

        required public string Msg;

        /// <summary>
        /// All APR information
        /// </summary>
        public List<APR>? Data;
    }

    /// <summary>
    /// The data in the field data is an array of real-time data for all APRs, each containing the following basic data
    /// </summary>
    public class APR
    {
        /// <summary>
        /// APR unique number
        /// </summary>
        public required string Id;
        public required int X; // mm
        public required int Y; // mm
        public required int Z; // mm
        /// <summary>
        /// Rotate angle (mdeg)
        /// </summary>
        public required int Theta; //angle
        /// <summary>
        /// The APR is loaded or unloaded: 0-No, 1-Yes
        /// </summary>
        public required int Cargo; 

    }


    /// GET MAP INFO
    
    // Request
    public class MapInfoRequest
    {
        public string? MapName;
    }

    //Response
    public class MapInfoResponse
    {
        /// <summary>
        /// 200 - Success Other - Failure
        /// </summary>
        public required int Code;
        /// <summary>
        /// Success, or reason for failure
        /// </summary>
        public required string Msg;
        /// <summary>
        /// Map details
        /// </summary>
        public string? Data; 
    }

    /// <summary>
    /// Point types are enumerated in the following table
    /// </summary>
    public enum PointType
    {
        RegularPoint  = 1,
        ParkingPoint  = 2,
        ChargingPoint = 10,
        Storage       = 40,
        Storage1      = 41,
        Storage2      = 42,
        PassingPoint  = 50 
    }


    public class Point
    {
        /// <summary>
        /// Point unique number
        /// </summary>
        public required int Id;
        /// <summary>
        /// /Point type
        /// </summary>
        public required int Type;
        /// <summary>
        /// X coordinate (mm)
        /// </summary>
        public required int X;
        /// <summary>
        /// Y coordinate (mm)
        /// </summary>
        public required int Y;
        /// <summary>
        /// Name of the point
        /// </summary>
        public string? Name;
        /// <summary>
        /// Neighbor points set
        /// </summary>
        public required HashSet<int> OutEdges;
    }

    class PointGraph
    {
        private int[,] AdjacencyMatrix;
        private readonly int NumberOfVertices;

        public PointGraph(int vertices)
        {
            NumberOfVertices = vertices;
            AdjacencyMatrix = new int[vertices, vertices];
        }

        public void AddEdge(int startVertex, int endVertex)
        {
            AdjacencyMatrix[startVertex, endVertex] = 1;
            AdjacencyMatrix[endVertex, startVertex] = 1; // Для неориентированного графа
        }
    }

}
