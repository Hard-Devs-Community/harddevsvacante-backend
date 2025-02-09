using System;
using AutoMapper;
using HardDevsVacantes.BusinessLayers.Dtos;
using HardDevsVacantes.DataModel.Entities;

namespace HardDevsVacantes.BusinessLayers.MappersLibrary
{
	public class SLibraryMapper : Profile
	{
		public SLibraryMapper()
		{
			CreateMap<Autor, AutorDto>().ReverseMap();
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Libro, LibroDto>().ReverseMap();
            CreateMap<Usuario, UsuarioDto>().ReverseMap();

            CreateMap<Usuario, AuthDto>().ReverseMap();

            CreateMap<LibroAutor, LibroAutorDto>().ReverseMap();
            CreateMap<LibroCategoria, LibroCategoriaDto>().ReverseMap();
        }
	}
}

