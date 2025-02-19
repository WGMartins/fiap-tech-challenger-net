﻿using TechChallenge.Domain.Interfaces;
using TechChallenge.UseCase.Interfaces;
using TechChallenge.UseCase.Shared;

namespace TechChallenge.UseCase.RegionalUseCase.Obter
{
    public class ObterRegionalUseCase : IObterRegionalUseCase
    {
        private readonly IRegionalRepository _regionalRepository;

        public ObterRegionalUseCase(IRegionalRepository regionalRepository)
        {
            _regionalRepository = regionalRepository;
        }

        public RegionalObtidaDto ObterPorId(Guid id)
        {
            var regional = _regionalRepository.ObterPorId(id);

            if (regional is null)
            {
                throw new Exception("Regional não encontrada");
            }

            return new RegionalObtidaDto
            {                
                Ddd = regional.Ddd,
                Estado = regional.Estado,
                Nome = regional.Nome
            };
        }


    }
}
