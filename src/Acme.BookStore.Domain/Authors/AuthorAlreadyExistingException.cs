using Volo.Abp;

namespace Acme.BookStore.Authors;

public class AuthorAlreadyExistingException : BusinessException
{
    public AuthorAlreadyExistingException(string name)
        : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}