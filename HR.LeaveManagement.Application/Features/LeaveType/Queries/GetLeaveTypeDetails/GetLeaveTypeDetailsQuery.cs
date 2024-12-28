using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;

public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailDto>;

//public class GetLeaveTypeDetailsQuery : IRequest<LeaveTypeDetailDto>
//{
//    public int Id { get; }

//    public GetLeaveTypeDetailsQuery(int id)
//    {
//        Id = id;
//    }
//}