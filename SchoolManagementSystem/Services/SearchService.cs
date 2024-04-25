using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Entities;


namespace SchoolManagementSystem.Services
{
	public class SearchService
	{
		private readonly SmsdbContext _dbContext;
		public SearchService(SmsdbContext smsdbContext)
		{
			_dbContext = smsdbContext;
		}
		public Student GetStudentByName(string name)
		{
			return _dbContext.Students.FirstOrDefault(a => a.FirstName == name);
		}

		public Student GetById(string admissionNumber)
		{
			return _dbContext.Students.FirstOrDefault(a => a.AdmissionNumber==admissionNumber);
		}
		public Teacher GetTeacherByName(string name)
		{
			return _dbContext.Teachers.FirstOrDefault(t => t.FirstName == name);
		}

	}
}

//using Microsoft.EntityFrameworkCore;
//using MusicStore.Data;

//namespace MusicStore;

public class AlbumSearchService
{
	//private const int PAGE_SIZE = 10;

	//private readonly MusicDbContext _dbContext;

	//public AlbumSearchService(MusicDbContext dbContext)
	//{
	//	_dbContext = dbContext;
	//}

	//public Album GetByName(string name)
	//{
	//	return _dbContext.Albums.FirstOrDefault(a => a.Title == name);
	//}

	//public Album GetById(int id)
	//{
	//	return _dbContext
	//		.Albums
	//		.FirstOrDefault(a => a.AlbumId == id);
	//}

	//public List<Album> GetFirst(int numberOfAlbums)
	//{
	//	return _dbContext.Albums.Take(numberOfAlbums).ToList();
	//}

	//public AlbumSearchResult SearchFor(string term, int page)
	//{
	//	if (page < 1)
	//	{
	//		return new AlbumSearchResult();
	//	}

	//	IQueryable<Album> query = _dbContext.Albums;

	//	if (!string.IsNullOrWhiteSpace(term))
	//	{
	//		query = query.Where(a => EF.Functions.Like(a.Title, $"%{term}%"));
	//	}

	//	var result = new AlbumSearchResult();

	//	result.RecordCount = query.Count();
	//	result.CurrentPage = page;
	//	result.SearchTerm = term;
	//	result.Albums.AddRange(query.Skip((page - 1) * PAGE_SIZE).Take(PAGE_SIZE).ToList());

	//	return result;
	//}
}