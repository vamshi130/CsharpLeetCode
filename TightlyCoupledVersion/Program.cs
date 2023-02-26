namespace TightlyCoupled
{
    ////Dependency
    //public class DAL
    //{
    //    public void GetEmployees()
    //    {
    //        Console.WriteLine("Get employees infl from database");
    //    }
    //}
    //public class InvertingClass   //for achieving IOC
    //{
    //    public static DAL GetInstanceDAL()
    //    {
    //        return new DAL();
    //    }
    //}
    ////Dependent
    //public class BAL
    //{
    //    //public DAL ObjDal = new DAL();
    //    public void GetEmployeesDAL()
    //    {
    //        //ObjDal.GetEmployees();
    //        DAL objDAL = InvertingClass.GetInstanceDAL();
    //        objDAL.GetEmployees();
    //    }
    //}

    //using Dependency Injection Loosely Coipled.
    public interface IEmployee
    {
        void GetEmployees();
    }
    public class DAL : IEmployee
    {
        public void GetEmployees()
        {
            Console.WriteLine("Get the employees info from database");
        }
    }
    public class BAL
    {
        public IEmployee _emp;
        public void GetEmployeesBAL(IEmployee emp)
        {
            _emp = emp;
            _emp.GetEmployees();
        }
    }
    
























    class program
    {
        static void Main(string[] args)
        {

        }
    }

}