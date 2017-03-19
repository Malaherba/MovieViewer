using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace objPelicula
{
    public partial class ControlPersonalizado : System.Windows.Forms.UserControl
    {
        public int codigo;
        public ControlPersonalizado()
        {
            InitializeComponent();
        }

        public void setImgMovie(string ruta) {
            //Método que nos permite definir la imagen que vamos a mostrar en el CP.
            btn_ImageMoviePreview.BackgroundImage = Image.FromFile(ruta);
        }

        public void setCodigo(int Codigo) {
            //Método que nos permite definir el codigo de la Pelicula que va a mostrar dicho CP.
            codigo = Codigo;
        }

        public Button getButton()
        {
            //Método que nos permite retornar el Button contenedor de la imagen.
            return btn_ImageMoviePreview;

        }
    }
}
