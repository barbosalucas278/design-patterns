using MediatorPattern.App.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediatorPattern.App
{
    public partial class Form1 : Form
    {
        Chat _chat;
        Usuario1 _usuario1;
        Usuario2 _usuario2;
        public Form1()
        {
            InitializeComponent();
            _chat = new ChatRoom();
            _usuario1 = new Usuario1("Usuario 1");
            _usuario2 = new Usuario2("Usuario 2");

            //Registro los usuarios al chat
            _chat.Registrar(_usuario1);
            _chat.Registrar(_usuario2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _chat.Enviar(this.textBox1.Text, _usuario2, _usuario1);
            MostrarMensajes();
            MostrarMensajesUsuario2();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _chat.Enviar(this.textBox2.Text, _usuario1, _usuario2);
            MostrarMensajes();
            MostrarMensajesUsuario1();
        }

        private void MostrarMensajes()
        {
            this.listBoxCentral.DataSource = null;
            this.listBoxCentral.DataSource = _chat.Mensajes;
        }
        private void MostrarMensajesUsuario1()
        {
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = _usuario1.Mensajes;
        }
        private void MostrarMensajesUsuario2()
        {
            this.listBox2.DataSource = null;
            this.listBox2.DataSource = _usuario2.Mensajes;
        }
    }
}