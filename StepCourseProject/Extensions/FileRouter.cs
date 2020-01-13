using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Extensions
{
    public class FileRouter : IRouter
    {
        private readonly IHostingEnvironment environment;

        public FileRouter(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            throw new NotImplementedException();
        }

        public Task RouteAsync(RouteContext context)
        {
            var path = context.HttpContext.Request.Path.Value.Split("/");

            RouteData routeData = new RouteData();


            if (path.Length == 1)
            {
                return Task.FromResult(0);
            }
            routeData.Values["controller"] = path[1];

            if (routeData.Values["controller"].ToString() == "Home")
            {
                var dataFolderPath = Path.Combine(environment.ContentRootPath, "Data");
                DirectoryInfo info = new DirectoryInfo(dataFolderPath);

                string actionName = path[2];

                var fileInfo = info.GetFiles().Where(x => x.Name.ToLower() == actionName.ToLower()).FirstOrDefault();
                if (fileInfo != null)

                    context.Handler = c =>
                    {
                        return c.Response.SendFileAsync(new SimpleFileInfo(fileInfo));
                    };
            }
            context.RouteData = routeData;
            return Task.FromResult(0);

        }
    }

    internal class SimpleFileInfo : IFileInfo
    {
        private FileInfo fullpath;

        public SimpleFileInfo(FileInfo path)

        {

            fullpath = path;

        }

        public bool Exists => fullpath.Exists;



        public long Length => fullpath.Length;



        public string PhysicalPath => fullpath.FullName;



        public string Name => fullpath.Name;



        public DateTimeOffset LastModified => fullpath.LastWriteTime;



        public bool IsDirectory => false;



        public Stream CreateReadStream()

        {

            return new FileStream(fullpath.FullName, FileMode.Open);

        }
    }
}
