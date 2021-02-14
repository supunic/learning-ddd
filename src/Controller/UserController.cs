// [Route("api/[controller]")]
public class UserController // : Controller
{
    private readonly IUserRegisterService userRegisteService;
    private readonly IUserGetAllInfoService userGetAllInfoService;
    private readonly IUserGetInfoService userGetInfoService;
    private readonly IUserUpdateInfoService userUpdateInfoService;
    private readonly IUserDeleteService userDeleteService;

    public UserController(
        IUserRegisterService   userRegisteService,
        IUserGetAllInfoService userGetAllInfoService,
        IUserGetInfoService    userGetInfoService,
        IUserUpdateInfoService userUpdateInfoService,
        IUserDeleteService     userDeleteService
    )
    {
        this.userRegisteService    = userRegisteService;
        this.userGetAllInfoService = userGetAllInfoService;
        this.userGetInfoService    = userGetInfoService;
        this.userUpdateInfoService = userUpdateInfoService;
        this.userDeleteService     = userDeleteService;
    }

    // [HttpGet]
    // public UserIndexResponseModel Index()
    // {
    //     var result = userGetAllInfoService.Handle();
    //     var users  = result.Users.Select(x => new UserResponseModel(x.Id, x.Name)).ToList();

    //     return new UserIndexResponseModel(users);
    // }

    // [HttpGet("{id}")]
    // public UserGetResponseModel Get(string id)
    // {
    //     var command = new UserGetInfoCommand(id);
    //     var result  = userGetInfoService.Handle(command);

    //     var userModel = new UserResponseModel(result.User);

    //     return new UserGetResponseModel(userModel);
    // }

    // [HttpPost]
    // public UserPostResponseModel Post([FromBody] UserPostRequestModel request)
    // {
    //     var command = new UserRegisterCommand(request.userName);
    //     var result  = userRegisteService.Handle(command);

    //     return new UserPostResponseModel(result.CreateUserId);
    // }

    // [HttpPut("{id}")]
    // public void Put(string id, [FromBody] UserPutRequestModel request)
    // {
    //     var command = new UserUpdateInfoCommand(id, request.Name);
    //     userUpdateInfoService.Handle(command);
    // }

    // [HttpDelete("{id}")]
    // public void Delete(string id)
    // {
    //     var command = new UserDeleteCommand(id);
    //     userDeleteService.Handle(command);
    // }
}
