﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.AutoPecas.WebApi.Domains;
using Senai.AutoPecas.WebApi.Interfaces;
using Senai.AutoPecas.WebApi.Repositories;

namespace Senai.AutoPecas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        IFornecedoresRepository IFornecedoresRepository;

        public FornecedoresController()
        {
            IFornecedoresRepository = new FornecedoresRepository();
        }

        [Authorize]
        [HttpGet("id")]
        public IActionResult BuscarPorCodigo(int id)
        {
            try
            {
                return Ok(IFornecedoresRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult Cadastrar(Fornecedores novoFornecedor)
        {
            try
            {
                IFornecedoresRepository.Cadastrar(novoFornecedor);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}