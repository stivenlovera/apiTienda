using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Services
{
    public class WriteFileService : IHostedService
    {
        Timer timer;
        private readonly IWebHostEnvironment _env;
        private readonly string nameFile = "RegistroApp.txt";
        public WriteFileService(IWebHostEnvironment env)
        {
            this._env = env;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            this.timer = new Timer(this.DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            Write("Proceso inicado");
            return Task.CompletedTask;
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            this.timer.Dispose();
            Write("Proceso finalizado");
            return Task.CompletedTask;
        }
        public void DoWork(object state)
        {
            Write("en ejecucion " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
        }
        private void Write(string message)
        {
            var path = $@"{this._env.ContentRootPath}\wwwroot\{nameFile}";
            using (StreamWriter write = new StreamWriter(path, append: true))
            {
                write.WriteLine(message);
            }
        }
    }
}