namespace Library.Console;

[Flags]
public enum CommonActions
{
    Repeat = 0,
    Select = 1,
    Quit = 2,
    SearchPatrons = 4,
    RenewPatronMembership = 8,
    ReturnLoanedBook = 16,
    ExtendLoanedBook = 32,
    SearchBooks = 64 // New action added
}
