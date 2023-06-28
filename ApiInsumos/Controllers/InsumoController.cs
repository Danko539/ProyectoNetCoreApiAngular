using ApiInsumos.Dtos;
using ApiInsumos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiInsumos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsumoController : ControllerBase
    {
        private InterfaceInsumoRepository insumoRepository;
        private ResponseDto responseDto;
        public InsumoController(InterfaceInsumoRepository insumoRepository)
        {
            this.insumoRepository = insumoRepository;
            this.responseDto = new ResponseDto();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<InsumoDto> insumoDtos = await insumoRepository.GetInsumos();
                this.responseDto.IsSucceed = true;
                this.responseDto.Result = insumoDtos;
                this.responseDto.DisplayMessage = "Success";
            }
            catch (Exception ex)
            {
                this.responseDto.IsSucceed = false;
                this.responseDto.DisplayMessage = ex.ToString();
            }

            return responseDto;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                InsumoDto insumoDto = await insumoRepository.GetInsumoById(id);
                this.responseDto.IsSucceed = true;
                this.responseDto.Result = insumoDto;
                this.responseDto.DisplayMessage = "Success";
            }
            catch(Exception ex) 
            {
                this.responseDto.IsSucceed = false;
                this.responseDto.DisplayMessage = ex.ToString();
            }

            return responseDto;
        }

        [HttpGet]
        [Route("/getBySeccion/{seccionCode}")]
        public async Task<object> Get(string seccionCode)
        {
            try
            {
                IEnumerable<InsumoDto> insumoDtos = await insumoRepository.GetInsumosBySeccionCode(seccionCode);
                this.responseDto.IsSucceed = true;
                this.responseDto.Result = insumoDtos;
                this.responseDto.DisplayMessage = "Success";
            }
            catch(Exception ex)
            {
                this.responseDto.IsSucceed = false;
                this.responseDto.DisplayMessage = ex.ToString();
            }

            return responseDto;
        }

        [HttpPost]
        public async Task<object> Post(InsumoDto insumoDto)
        {
            try
            {
                InsumoDto result = await insumoRepository.CreateInsumo(insumoDto);
                this.responseDto.IsSucceed = true;
                this.responseDto.Result = result;
                this.responseDto.DisplayMessage = "Success";
            }
            catch(Exception ex)
            {
                this.responseDto.IsSucceed = false;
                this.responseDto.DisplayMessage = ex.ToString();
            }

            return responseDto;
        }

        [HttpPut]
        public async Task<object> Put(InsumoDto insumoDto)
        {
            try
            {
                InsumoDto result = await insumoRepository.UpdateInsumo(insumoDto);
                this.responseDto.IsSucceed = true;
                this.responseDto.Result = result;
            }
            catch(Exception ex)
            {
                this.responseDto.IsSucceed = false;
                this.responseDto.DisplayMessage = ex.ToString();
            }

            return responseDto;
        }

        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool result = await insumoRepository.DeleteInsumo(id);
                this.responseDto.IsSucceed = true;
                this.responseDto.Result = result;
                this.responseDto.DisplayMessage = "Success";
            }
            catch(Exception ex)
            {
                this.responseDto.IsSucceed = false;
                this.responseDto.DisplayMessage = ex.ToString();
            }

            return responseDto;
        }
    }
}
