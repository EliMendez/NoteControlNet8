using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NoteControlNet8.Repository.Interface;

namespace NoteControlNet8.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ISubject _iSubject;
        private readonly IMapper _mapper;

        public SubjectController(ISubject iSubject, IMapper iMapper)
        {
            _iSubject = iSubject;
            _mapper = iMapper;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _iSubject.GetAll();
            return View(list);
        }
    }
}
