﻿using AutenticacaoMarcusApi.Features.Grupos.ValueObjects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutenticacaoMarcusApi.Features.Grupos.Requests.ListarTodosGrupos
{
    public class ListarTodosGruposRequest : IRequest<IEnumerable<GrupoDto>>
    {
    }
}
