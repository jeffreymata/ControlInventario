using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiInventario.Features.Models;

namespace WebApiInventario.Features.DomainService
{
    public class EquipmentDomainService
    {
        public string PostEquipmentDetailDomainService(EquipmentDetail equipmentDetail)
        {
            if (equipmentDetail.Equipments.Marca == "HP")
            {
                return "No se puede ingresar la marca HP";
            }

            if (equipmentDetail.Tipo == "Dañado")
            {
                return "No se puede ingresar equipo de tipo Dañado";
            }

            return null;
        }
    }
}
