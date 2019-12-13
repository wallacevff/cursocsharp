using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace ReferenciaValor {
    partial class Service1 : ServiceBase {
        public Service1() {
            InitializeComponent();
        }

        protected override void OnStart(string[] args) {
            // TODO: Adicione aqui o código para iniciar seu serviço.
        }

        protected override void OnStop() {
            // TODO: Adicione aqui o código para realizar qualquer desmontagem necessária para interromper seu serviço.
        }
    }
}
