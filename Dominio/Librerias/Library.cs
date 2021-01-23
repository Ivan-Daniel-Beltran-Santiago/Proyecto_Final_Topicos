using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Librerias
{
    public class Library: Connection
    {
        public uploadImage uImage = new uploadImage();
        public TextBoxEvent tbxEvent = new TextBoxEvent();
    }
}
