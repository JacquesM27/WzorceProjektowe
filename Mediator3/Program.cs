using Mediator3.CQRS.Order.Command.PlaceOrder;
using Mediator3.CQRS.Order.Command.ProcessPayment;
using Mediator3.CQRS.Order.Command.ShipOrder;
using Mediator3.DTO;
using Mediator3.Mediator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());

builder.Services.AddScoped<IMediator, Mediator>();
builder.Services.AddScoped<IRequestHandler<PlaceOrderCommand, PlaceOrderResult>, PlaceOrderCommandHandler>();
builder.Services.AddScoped<PlaceOrderCommand>();
builder.Services.AddScoped<IRequestHandler<ProcessPaymentCommand, PaymentResult>, ProcessPaymentCommandHandler>();
builder.Services.AddScoped<ProcessPaymentCommand>();
builder.Services.AddScoped<IRequestHandler<ShipOrderCommand, ShipOrderResult>, ShipOrderCommandHandler>();
builder.Services.AddScoped<ShipOrderCommand>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
