using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiInventario.Features.EquipmentMaster;
using Microsoft.EntityFrameworkCore;
using WebApiInventario.Features.DomainService;
using WebApiInventario.Features.Models;
using WebApiInventario.Features.Helpers;

namespace WebApiInventario.Features.ApplicationService
{
    public class EquipmentDetailAppService
    {
        private readonly Context _baseDatos;
        private readonly EquipmentDomainService _equipmentDomainService;

        public EquipmentDetailAppService(Context context, EquipmentDomainService equipmentDomainService)
        {
            _baseDatos = context;
            _equipmentDomainService = equipmentDomainService;
        }

        /*
        public async Task<Result> PostEquipmentApplicationService(Equipment equipment)
        {

            var respuestaDomainService = _equipmentDomainService.PostEquipmentDetailDomainService(equipment);

            bool ErrorEnDomainService = respuestaDomainService != null;

            if (ErrorEnDomainService)
            {
                return new Result { Message = respuestaDomainService };
            }

            _baseDatos.Equipments.Add(equipment);
            await _baseDatos.SaveChangesAsync();

            return null;

        }
        */
        /*

        public async Task<Result> GetEquipment()
        {
            var Equipments = await _baseDatos.Details.Include(q => q.Equipments).ToListAsync();
            return new Result { Information = Equipments };
        }
        
        public async Task<EquipmentDetail> LlamadaBaseDeDatos(Equipment equipment)
        {
            
        }
        */
    }
}
