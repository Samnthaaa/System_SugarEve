namespace SugarEveSystem.Models
{
    /// <summary>
    /// Plantillas predefinidas de secciones e ítems para cada tipo de servicio.
    /// Cuando el usuario proporcione los checklists específicos, se actualizan aquí.
    /// </summary>
    public static class PlantillaChecklist
    {
        public static List<CheckItemSeccion> ObtenerPlantilla(string tipoServicio)
        {
            return tipoServicio switch
            {
                "Backdrops" => Backdrops(),
                "Miniferia" => Miniferia(),
                "BarraSnacks" => BarraSnacks(),
                "MesaDulces" => MesaDulces(),
                "Algodones" => Algodones(),
                "Palomitas" => Palomitas(),
                "Churros" => Churros(),
                "CatalogoPaneles" => CatalogoPaneles(),
                _ => Generica()
            };
        }

        private static List<CheckItemSeccion> Backdrops() => new()
        {
            new CheckItemSeccion
            {
                NombreSeccion = "Materiales",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Bases metálicas / estructura del backdrop", Completado = false },
                    new() { Descripcion = "Globos (colores según paleta del evento)", Completado = false },
                    new() { Descripcion = "Globos de helio (tamaños requeridos)", Completado = false },
                    new() { Descripcion = "Flores decorativas / follaje", Completado = false },
                    new() { Descripcion = "Luces LED / cintillo de luz", Completado = false },
                    new() { Descripcion = "Letras o letrero del evento", Completado = false },
                    new() { Descripcion = "Tela / fondo de color", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Logística",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Confirmación de dirección del venue", Completado = false },
                    new() { Descripcion = "Hora de llegada para montaje", Completado = false },
                    new() { Descripcion = "Herramientas de montaje (cinta, tijeras, hilo)", Completado = false },
                    new() { Descripcion = "Materiales cargados en vehículo", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Montaje",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Estructura armada y nivelada", Completado = false },
                    new() { Descripcion = "Globos inflados y colocados", Completado = false },
                    new() { Descripcion = "Decoración adicional instalada", Completado = false },
                    new() { Descripcion = "Fotos de montaje tomadas", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Cierre",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Materiales recogidos al terminar el evento", Completado = false },
                    new() { Descripcion = "Inventario actualizado", Completado = false },
                    new() { Descripcion = "Confirmación final del cliente", Completado = false },
                }
            }
        };

        private static List<CheckItemSeccion> Miniferia() => new()
        {
            new CheckItemSeccion
            {
                NombreSeccion = "Materiales",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Juegos y atracciones de feria", Completado = false },
                    new() { Descripcion = "Premios y piñatas", Completado = false },
                    new() { Descripcion = "Mesas y sillas para estaciones", Completado = false },
                    new() { Descripcion = "Mantelería decorativa", Completado = false },
                    new() { Descripcion = "Señalética de estaciones", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Logística",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Confirmación de espacio disponible en venue", Completado = false },
                    new() { Descripcion = "Traslado de equipo confirmado", Completado = false },
                    new() { Descripcion = "Personal asignado por estación", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Montaje",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Estaciones instaladas y alineadas", Completado = false },
                    new() { Descripcion = "Juegos probados y funcionando", Completado = false },
                    new() { Descripcion = "Decoración por estación colocada", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Cierre",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Equipo desarmado y guardado", Completado = false },
                    new() { Descripcion = "Premios sobrantes inventariados", Completado = false },
                    new() { Descripcion = "Confirmación final del cliente", Completado = false },
                }
            }
        };

        private static List<CheckItemSeccion> BarraSnacks() => new()
        {
            new CheckItemSeccion
            {
                NombreSeccion = "Materiales",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Mesa principal de la barra", Completado = false },
                    new() { Descripcion = "Mantelería y decoración de mesa", Completado = false },
                    new() { Descripcion = "Snacks salados (papas, pretzels, etc.)", Completado = false },
                    new() { Descripcion = "Snacks dulces (galletas, chocolates, etc.)", Completado = false },
                    new() { Descripcion = "Servilletas y recipientes", Completado = false },
                    new() { Descripcion = "Letrero / señalética de la barra", Completado = false },
                    new() { Descripcion = "Utensilios (pinzas, cucharas)", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Logística",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Snacks comprados y empacados", Completado = false },
                    new() { Descripcion = "Refrigeración disponible si es necesario", Completado = false },
                    new() { Descripcion = "Traslado de materiales confirmado", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Montaje y Servicio",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Mesa montada y decorada", Completado = false },
                    new() { Descripcion = "Snacks dispuestos en recipientes", Completado = false },
                    new() { Descripcion = "Letrero colocado", Completado = false },
                    new() { Descripcion = "Reposición durante el evento", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Cierre",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Sobrantes empacados o desechados", Completado = false },
                    new() { Descripcion = "Materiales recuperados e inventariados", Completado = false },
                    new() { Descripcion = "Confirmación final del cliente", Completado = false },
                }
            }
        };

        private static List<CheckItemSeccion> MesaDulces() => new()
        {
            new CheckItemSeccion
            {
                NombreSeccion = "Materiales",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Base/estructura de la mesa de dulces", Completado = false },
                    new() { Descripcion = "Mantelería y faldón decorativo", Completado = false },
                    new() { Descripcion = "Dulces a granel (variedad)", Completado = false },
                    new() { Descripcion = "Pastel o pieza central", Completado = false },
                    new() { Descripcion = "Recipientes y bowls decorativos", Completado = false },
                    new() { Descripcion = "Bolsitas o cajitas para llevar", Completado = false },
                    new() { Descripcion = "Letrero y señalética", Completado = false },
                    new() { Descripcion = "Flowers/globos decorativos", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Logística",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Cantidad de dulces calculada para invitados", Completado = false },
                    new() { Descripcion = "Paleta de colores confirmada con cliente", Completado = false },
                    new() { Descripcion = "Traslado seguro de piezas delicadas", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Montaje",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Estructura armada y nivelada", Completado = false },
                    new() { Descripcion = "Dulces acomodados por recipiente", Completado = false },
                    new() { Descripcion = "Pastel principal colocado", Completado = false },
                    new() { Descripcion = "Decoraciones finales puestas", Completado = false },
                    new() { Descripcion = "Fotos del montaje tomadas", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Cierre",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Materiales recuperados e inventariados", Completado = false },
                    new() { Descripcion = "Confirmación final del cliente", Completado = false },
                }
            }
        };

        private static List<CheckItemSeccion> Algodones() => new()
        {
            new CheckItemSeccion
            {
                NombreSeccion = "Materiales",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Máquina de algodón de azúcar", Completado = false },
                    new() { Descripcion = "Azúcar de colores (sabores surtidos)", Completado = false },
                    new() { Descripcion = "Palitos para algodón", Completado = false },
                    new() { Descripcion = "Bolsas / empaques para algodón", Completado = false },
                    new() { Descripcion = "Mesa y mantelería de la estación", Completado = false },
                    new() { Descripcion = "Letrero de estación", Completado = false },
                    new() { Descripcion = "Extensión eléctrica (si aplica)", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Logística",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Toma de corriente disponible en venue", Completado = false },
                    new() { Descripcion = "Máquina limpia y revisada", Completado = false },
                    new() { Descripcion = "Cantidad de azúcar calculada", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Operación",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Máquina encendida y calibrada", Completado = false },
                    new() { Descripcion = "Estación decorada y lista", Completado = false },
                    new() { Descripcion = "Servicio activo durante el evento", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Cierre",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Máquina apagada y limpiada", Completado = false },
                    new() { Descripcion = "Insumos sobrantes guardados", Completado = false },
                    new() { Descripcion = "Confirmación final del cliente", Completado = false },
                }
            }
        };

        private static List<CheckItemSeccion> Palomitas() => new()
        {
            new CheckItemSeccion
            {
                NombreSeccion = "Materiales",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Máquina de palomitas", Completado = false },
                    new() { Descripcion = "Maíz palomero (cantidad calculada)", Completado = false },
                    new() { Descripcion = "Aceite / mantequilla", Completado = false },
                    new() { Descripcion = "Sal y sazonadores", Completado = false },
                    new() { Descripcion = "Conos o bolsas de palomitas", Completado = false },
                    new() { Descripcion = "Mesa y mantelería de la estación", Completado = false },
                    new() { Descripcion = "Letrero de estación", Completado = false },
                    new() { Descripcion = "Extensión eléctrica (si aplica)", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Logística",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Toma de corriente disponible", Completado = false },
                    new() { Descripcion = "Máquina limpia y en buen estado", Completado = false },
                    new() { Descripcion = "Insumos comprados y empacados", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Operación",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Máquina encendida y probada", Completado = false },
                    new() { Descripcion = "Estación decorada y activa", Completado = false },
                    new() { Descripcion = "Servicio continuo durante el evento", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Cierre",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Máquina apagada y limpiada", Completado = false },
                    new() { Descripcion = "Insumos sobrantes guardados", Completado = false },
                    new() { Descripcion = "Confirmación final del cliente", Completado = false },
                }
            }
        };

        private static List<CheckItemSeccion> Churros() => new()
        {
            new CheckItemSeccion
            {
                NombreSeccion = "Materiales",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Churrera / equipo de fritura", Completado = false },
                    new() { Descripcion = "Masa para churros (preparada o en polvo)", Completado = false },
                    new() { Descripcion = "Aceite para fritura", Completado = false },
                    new() { Descripcion = "Azúcar y canela", Completado = false },
                    new() { Descripcion = "Salsas de dipping (chocolate, cajeta, etc.)", Completado = false },
                    new() { Descripcion = "Servilletas y contenedores", Completado = false },
                    new() { Descripcion = "Mesa y mantelería de la estación", Completado = false },
                    new() { Descripcion = "Letrero de estación", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Logística",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Condiciones de fritura seguras verificadas", Completado = false },
                    new() { Descripcion = "Toma de corriente o gas disponible", Completado = false },
                    new() { Descripcion = "Insumos comprados y transportados", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Operación",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Equipo caliente y listo para producir", Completado = false },
                    new() { Descripcion = "Churros producidos y disponibles", Completado = false },
                    new() { Descripcion = "Servicio activo durante el evento", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Cierre",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Equipo apagado y limpiado", Completado = false },
                    new() { Descripcion = "Aceite y sobrantes desechados correctamente", Completado = false },
                    new() { Descripcion = "Confirmación final del cliente", Completado = false },
                }
            }
        };

        private static List<CheckItemSeccion> CatalogoPaneles() => new()
        {
            new CheckItemSeccion
            {
                NombreSeccion = "Materiales",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Paneles seleccionados según diseño acordado", Completado = false },
                    new() { Descripcion = "Herrajes y fijaciones de paneles", Completado = false },
                    new() { Descripcion = "Herramientas de instalación", Completado = false },
                    new() { Descripcion = "Decoración adicional para paneles", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Logística",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Diseño de paneles aprobado por cliente", Completado = false },
                    new() { Descripcion = "Paneles limpios y en buen estado", Completado = false },
                    new() { Descripcion = "Traslado seguro de paneles", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Instalación",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Paneles instalados según plano acordado", Completado = false },
                    new() { Descripcion = "Verificar estabilidad y nivel", Completado = false },
                    new() { Descripcion = "Decoración aplicada sobre paneles", Completado = false },
                    new() { Descripcion = "Fotos de instalación tomadas", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Cierre",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Paneles desinstalados y guardados", Completado = false },
                    new() { Descripcion = "Herrajes revisados e inventariados", Completado = false },
                    new() { Descripcion = "Confirmación final del cliente", Completado = false },
                }
            }
        };

        private static List<CheckItemSeccion> Generica() => new()
        {
            new CheckItemSeccion
            {
                NombreSeccion = "Materiales",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Verificar lista de materiales", Completado = false },
                }
            },
            new CheckItemSeccion
            {
                NombreSeccion = "Cierre",
                Items = new List<CheckItem>
                {
                    new() { Descripcion = "Confirmación final del cliente", Completado = false },
                }
            }
        };
    }
}
