using SugarEveSystem.Models;

namespace SugarEveSystem.Services
{
    /// <summary>
    /// Datos de muestra estáticos que se muestran cuando Firebase no está configurado.
    /// </summary>
    public static class DatosEjemplo
    {
        public static List<Cotizacion> ObtenerCotizaciones()
        {
            var hoy = DateTime.Today;
            return new List<Cotizacion>
            {
                new() {
                    Id = "demo-1",
                    NombreCliente = "Gabriela Martínez",
                    TipoEvento = "XV Años",
                    TipoServicio = "Backdrops",
                    FechaEvento = hoy.AddDays(2).ToString("yyyy-MM-dd"),
                    MontoCotizado = 6500,
                    Estado = "Confirmado",
                    Detalles = "Backdrop rosa con letras doradas, globos metalizados. Entrega a las 10am en Salón Paraíso."
                },
                new() {
                    Id = "demo-2",
                    NombreCliente = "Sofía Ramos",
                    TipoEvento = "Baby Shower",
                    TipoServicio = "MesaDulces",
                    FechaEvento = hoy.AddDays(5).ToString("yyyy-MM-dd"),
                    MontoCotizado = 4200,
                    Estado = "Confirmado",
                    Detalles = "Mesa de dulces temática Oso Panda, colores azul y blanco. 50 invitados."
                },
                new() {
                    Id = "demo-3",
                    NombreCliente = "Fernanda Ortega",
                    TipoEvento = "Cumpleaños",
                    TipoServicio = "BarraSnacks",
                    FechaEvento = hoy.AddDays(12).ToString("yyyy-MM-dd"),
                    MontoCotizado = 2800,
                    Estado = "Pendiente",
                    Detalles = "Barra de snacks salados y dulces para 80 personas. Colores pastel."
                },
                new() {
                    Id = "demo-4",
                    NombreCliente = "Valentina Cruz",
                    TipoEvento = "Graduación",
                    TipoServicio = "Algodones",
                    FechaEvento = hoy.AddDays(18).ToString("yyyy-MM-dd"),
                    MontoCotizado = 1500,
                    Estado = "Pendiente",
                    Detalles = "Estación de algodones de azúcar en colores universitarios (azul y blanco)."
                },
                new() {
                    Id = "demo-5",
                    NombreCliente = "Mariana Ibáñez",
                    TipoEvento = "Boda",
                    TipoServicio = "Churros",
                    FechaEvento = hoy.AddDays(30).ToString("yyyy-MM-dd"),
                    MontoCotizado = 3500,
                    Estado = "Confirmado",
                    Detalles = "Estación de churros con cajeta, chocolate y nutella para 120 invitados."
                },
                new() {
                    Id = "demo-6",
                    NombreCliente = "Camila Torres",
                    TipoEvento = "Feria Escolar",
                    TipoServicio = "Miniferia",
                    FechaEvento = hoy.AddDays(45).ToString("yyyy-MM-dd"),
                    MontoCotizado = 8900,
                    Estado = "Pendiente",
                    Detalles = "Mini feria con 5 juegos diferentes. Premios incluidos. Horario: 10am - 3pm."
                },
                new() {
                    Id = "demo-7",
                    NombreCliente = "Daniela Fuentes",
                    TipoEvento = "Bautizo",
                    TipoServicio = "CatalogoPaneles",
                    FechaEvento = hoy.AddDays(-10).ToString("yyyy-MM-dd"),
                    MontoCotizado = 3200,
                    Estado = "Confirmado",
                    Detalles = "Panel de flores lila con cruz dorada. Realizado exitosamente."
                },
                new() {
                    Id = "demo-8",
                    NombreCliente = "Lucía Herrera",
                    TipoEvento = "Posada",
                    TipoServicio = "Palomitas",
                    FechaEvento = hoy.AddDays(-20).ToString("yyyy-MM-dd"),
                    MontoCotizado = 1200,
                    Estado = "Cancelado",
                    Detalles = "Cancelado por cliente con 2 días de anticipación."
                }
            };
        }

        public static List<ServicioChecklist> ObtenerChecklists()
        {
            return new List<ServicioChecklist>
            {
                new() {
                    Id = "chk-demo-1",
                    TituloServicio = "Backdrop XV Años – Gabriela",
                    TipoServicio = "Backdrops",
                    EventoAsociado = "XV Años Gabriela Martínez",
                    Responsable = "Samy",
                    Estado = "Preparación",
                    ConfirmacionFinal = false,
                    Secciones = new List<CheckItemSeccion>
                    {
                        new() { NombreSeccion = "Materiales", Items = new() {
                            new() { Descripcion = "Estructura metálica circular", Completado = true },
                            new() { Descripcion = "Globos rosa y dorado (x50)", Completado = true },
                            new() { Descripcion = "Letras \"GABRIELA\" doradas", Completado = false },
                            new() { Descripcion = "Flores artificiales blancas", Completado = false },
                        }},
                        new() { NombreSeccion = "Logística", Items = new() {
                            new() { Descripcion = "Dirección del venue confirmada", Completado = true },
                            new() { Descripcion = "Llegada a las 10am", Completado = false },
                        }},
                        new() { NombreSeccion = "Montaje", Items = new() {
                            new() { Descripcion = "Estructura armada", Completado = false },
                            new() { Descripcion = "Globos colocados", Completado = false },
                        }},
                        new() { NombreSeccion = "Cierre", Items = new() {
                            new() { Descripcion = "Materiales recogidos", Completado = false },
                            new() { Descripcion = "Confirmación del cliente", Completado = false },
                        }}
                    }
                },
                new() {
                    Id = "chk-demo-2",
                    TituloServicio = "Mesa de Dulces – Baby Shower Sofía",
                    TipoServicio = "MesaDulces",
                    EventoAsociado = "Baby Shower Sofía Ramos",
                    Responsable = "Samy",
                    Estado = "Preparación",
                    ConfirmacionFinal = false,
                    Secciones = new List<CheckItemSeccion>
                    {
                        new() { NombreSeccion = "Materiales", Items = new() {
                            new() { Descripcion = "Base redonda blanca", Completado = true },
                            new() { Descripcion = "Mantelería azul cielo", Completado = true },
                            new() { Descripcion = "Dulces a granel (500g surtidos)", Completado = false },
                            new() { Descripcion = "Pastel temático Oso Panda", Completado = false },
                            new() { Descripcion = "Bolsitas de recuerdo (x50)", Completado = false },
                        }},
                        new() { NombreSeccion = "Montaje", Items = new() {
                            new() { Descripcion = "Mesa armada y decorada", Completado = false },
                            new() { Descripcion = "Foto del montaje tomada", Completado = false },
                        }}
                    }
                }
            };
        }
    }
}
