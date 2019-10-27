using JobAutomation.Repository;

namespace JobAutomation.UnitofWork
{
    public interface IJobUnitofWork : IUnitofWork
    {
        JobRepository JobRepository { get; }

      
    }
}