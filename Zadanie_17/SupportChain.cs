using System;

public enum TicketType
{
    Technical,
    Billing,
    General
}

public class SupportTicket
{
    public TicketType Type { get; set; }
    public string Description { get; set; }

    public SupportTicket(TicketType type, string description)
    {
        Type = type;
        Description = description;
    }
}

public abstract class SupportHandler
{
    private SupportHandler next;

    public SupportHandler SetNext(SupportHandler handler)
    {
        next = handler;
        return handler;
    }

    public abstract void Handle(SupportTicket ticket);

    protected void PassToNext(SupportTicket ticket)
    {
        if (next != null)
            next.Handle(ticket);
        else
            Console.WriteLine($"Brak handlera dla zgłoszenia: {ticket.Description}");
    }
}

public class TechnicalHandler : SupportHandler
{
    public override void Handle(SupportTicket ticket)
    {
        if (ticket.Type == TicketType.Technical)
            Console.WriteLine($"Dział techniczny obsługuje: {ticket.Description}");
        else
            PassToNext(ticket);
    }
}

public class BillingHandler : SupportHandler
{
    public override void Handle(SupportTicket ticket)
    {
        if (ticket.Type == TicketType.Billing)
            Console.WriteLine($"Dział rozliczeń obsługuje: {ticket.Description}");
        else
            PassToNext(ticket);
    }
}

public class GeneralHandler : SupportHandler
{
    public override void Handle(SupportTicket ticket)
    {
        if (ticket.Type == TicketType.General)
            Console.WriteLine($"Obsługa ogólna obsługuje: {ticket.Description}");
        else
            PassToNext(ticket);
    }
}

// Kod testowy
public class Program
{
    public static void Main(string[] args)
    {
        TechnicalHandler technical = new TechnicalHandler();
        BillingHandler billing = new BillingHandler();
        GeneralHandler general = new GeneralHandler();

        technical.SetNext(billing).SetNext(general);

        SupportTicket[] tickets = {
            new SupportTicket(TicketType.Technical, "Komputer się zawiesza"),
            new SupportTicket(TicketType.Billing, "Błąd na fakturze"),
            new SupportTicket(TicketType.General, "Pytanie o godziny pracy")
        };

        foreach (var ticket in tickets)
        {
            technical.Handle(ticket);
        }
    }
}
