//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Vivero.Negocio.EstructuraNegocio
//{
//	class Es_Cliente
//	{
//		public string TipoDoc { get; set; }
//		public string NroDoc { get; set; }
//		public string Nombre { get; set; }
//		public string Apellido { get; set; }
//		public string Calle { get; set; }
//		public string NroCalle { get; set; }
//		public string Barrio { get; set; }
//		public string Localidad { get; set; }
//		public string Telefono { get; set; }
//		public string Email { get; set; }
//		public string Estado { get; set; }
//	}
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.Entidades;

namespace Vivero.Negocio.EstructuraNegocio
{
	class Es_Cliente
	{
		public Es_TipoDoc TipoDoc { get; set; }
		public string NroDoc { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Calle { get; set; }
		public string NroCalle { get; set; }
		public Es_Barrio Barrio { get; set; }
		public Es_Localidad Localidad { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }
		public int Estado { get; set; }
	}
}
