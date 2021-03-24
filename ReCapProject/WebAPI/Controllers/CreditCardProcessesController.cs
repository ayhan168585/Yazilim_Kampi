using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardProcessesController : ControllerBase
    {
        private ICreditCardProcessService _creditCardProcessService;

        public CreditCardProcessesController(ICreditCardProcessService creditCardProcessService)
        {
            _creditCardProcessService = creditCardProcessService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _creditCardProcessService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getcardprocessdetails")]

        public IActionResult GetCardProcessDetails()
        {
            var result = _creditCardProcessService.GetCardProcessDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getcardprocessdetailsbycardid")]

        public IActionResult GetCardProcessDetailsByCardId(int cardId)
        {
            var result = _creditCardProcessService.GetCardProcessDetailsByCardId(cardId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getcardprocessdetailsbyprocessid")]

        public IActionResult GetCardProcessDetailsByProcessId(int processId)
        {
            var result = _creditCardProcessService.GetCardProcessDetailsByProcessId(processId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]

        public IActionResult GetById(int id)
        {
            var result = _creditCardProcessService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getcardprocessbybankid")]

        public IActionResult GetCardProcessByBankId(int bankId)
        {
            var result = _creditCardProcessService.GetCardProcessByBankId(bankId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]

        public IActionResult Add(CreditCardProcess process)
        {
            var result = _creditCardProcessService.Add(process);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("update")]

        public IActionResult Update(CreditCardProcess process)
        {
            var result = _creditCardProcessService.Update(process);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]

        public IActionResult Delete(CreditCardProcess process)
        {
            var result = _creditCardProcessService.Delete(process);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
