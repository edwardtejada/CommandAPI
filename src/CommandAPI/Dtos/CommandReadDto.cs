namespace CommandAPI.Dtos
{
    public class CommandReadDto
    {
        public int Id {get; set;}
        public string HowTo {get; set;}
        //public string Platform {get; set;}
        public string CommandLine {get; set;}
    }
}

//dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
//dotnet add package Microsoft.AspNetCore.JsonPatch
//dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson