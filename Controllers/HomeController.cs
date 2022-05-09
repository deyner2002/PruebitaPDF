using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Mvc;
using PruebitaPDF.Models;
using System.Diagnostics;

namespace PruebitaPDF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PDF()
        {
            NumberServiceSolicitudeByState numberServiceSolicitudeByState = new NumberServiceSolicitudeByState();
            numberServiceSolicitudeByState.AmountClosed = 12000;
            numberServiceSolicitudeByState.AmountCanceled = 8000;
            numberServiceSolicitudeByState.AmountPending = 20000;
            numberServiceSolicitudeByState.AmountInProgress = 100000;
            numberServiceSolicitudeByState.TotalAmount = 120000;

            NumberServiceOrderByState numberServiceOrderByState = new NumberServiceOrderByState();
            numberServiceOrderByState.AmountFinishedApproved = 20000;
            numberServiceOrderByState.AmountFinishedRejected = 10000;
            numberServiceOrderByState.AmountPending = 5000;
            numberServiceOrderByState.AmountPendingAssignment = 12300;
            numberServiceOrderByState.AmountInProgress = 4000;
            numberServiceOrderByState.AmountCancelled = 30000;
            numberServiceOrderByState.AmountAssigned = 5000;
            numberServiceOrderByState.TotalAmount = 700000;

            
            NumberOfTimesTheyRequestService numberOfTimesTheyRequestService= new NumberOfTimesTheyRequestService();
            numberOfTimesTheyRequestService.Amount = 500000;
            numberOfTimesTheyRequestService.ServiceName = "Servicio regalias";

            NumberOfTimesTheyRequestService numberOfTimesTheyRequestService2 = new NumberOfTimesTheyRequestService();
            numberOfTimesTheyRequestService2.Amount = 100000;
            numberOfTimesTheyRequestService2.ServiceName = "Servicio importado";

            NumberOfTimesTheyRequestService numberOfTimesTheyRequestService3 = new NumberOfTimesTheyRequestService();
            numberOfTimesTheyRequestService3.Amount = 2000000;
            numberOfTimesTheyRequestService3.ServiceName = "Servicio extremo";

            List<NumberOfTimesTheyRequestService> NumbersOfTimesTheyRequestService = new List<NumberOfTimesTheyRequestService>();
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService2);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService3);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService2);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService3);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService2);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService3);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService2);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService3);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService2);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService3);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService);
            NumbersOfTimesTheyRequestService.Add(numberOfTimesTheyRequestService2);
            


            TotalPaidByCustomer totalPaidByCustomer = new TotalPaidByCustomer();
            totalPaidByCustomer.CustomerName = "FDeyner solano";
            totalPaidByCustomer.TotalGenerated = 70000000;

            TotalPaidByCustomer totalPaidByCustomer2 = new TotalPaidByCustomer();
            totalPaidByCustomer2.CustomerName = "Alejandro buitrago";
            totalPaidByCustomer2.TotalGenerated = 71500000;

            TotalPaidByCustomer totalPaidByCustomer3 = new TotalPaidByCustomer();
            totalPaidByCustomer3.CustomerName = "Diego Cotes";
            totalPaidByCustomer3.TotalGenerated = 60000000;

            List<TotalPaidByCustomer> totalPaidByCustomers = new List<TotalPaidByCustomer>();
            totalPaidByCustomers.Add(totalPaidByCustomer);
            totalPaidByCustomers.Add(totalPaidByCustomer2);
            totalPaidByCustomers.Add(totalPaidByCustomer3);
            totalPaidByCustomers.Add(totalPaidByCustomer);
            totalPaidByCustomers.Add(totalPaidByCustomer2);
            totalPaidByCustomers.Add(totalPaidByCustomer3);
            totalPaidByCustomers.Add(totalPaidByCustomer);
            totalPaidByCustomers.Add(totalPaidByCustomer2);
            totalPaidByCustomers.Add(totalPaidByCustomer3);
            totalPaidByCustomers.Add(totalPaidByCustomer);
            totalPaidByCustomers.Add(totalPaidByCustomer2);
            totalPaidByCustomers.Add(totalPaidByCustomer3);
            totalPaidByCustomers.Add(totalPaidByCustomer);
            totalPaidByCustomers.Add(totalPaidByCustomer2);
            totalPaidByCustomers.Add(totalPaidByCustomer3);
            totalPaidByCustomers.Add(totalPaidByCustomer);
            totalPaidByCustomers.Add(totalPaidByCustomer2);
            totalPaidByCustomers.Add(totalPaidByCustomer3);
            totalPaidByCustomers.Add(totalPaidByCustomer);
            totalPaidByCustomers.Add(totalPaidByCustomer2);
            totalPaidByCustomers.Add(totalPaidByCustomer3);
            totalPaidByCustomers.Add(totalPaidByCustomer);
            totalPaidByCustomers.Add(totalPaidByCustomer2);
            totalPaidByCustomers.Add(totalPaidByCustomer3);
            totalPaidByCustomers.Add(totalPaidByCustomer);
            totalPaidByCustomers.Add(totalPaidByCustomer2);
            totalPaidByCustomers.Add(totalPaidByCustomer3);
            totalPaidByCustomers.Add(totalPaidByCustomer);

            
            MemoryStream ms = new MemoryStream();
            PdfWriter pw = new PdfWriter(ms);
            PdfDocument pdfDocument = new PdfDocument(pw);
            Document doc = new Document(pdfDocument, PageSize.LETTER);
            doc.SetMargins(55, 35, 60, 35);

            Table tableHeader = new Table(1).UseAllAvailableWidth();
            Cell cellHeader = new Cell().Add(new Paragraph("Reporte DashBoard").SetFontSize(20))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER);
            tableHeader.AddCell(cellHeader);
            doc.Add(tableHeader);


            doc.Add(new Paragraph(""));

            doc.Add(CreateCaption("Numero servicio solicitud por estado"));

            List<string> HeaderCellsServiceSolicitude = new List<string>();
            HeaderCellsServiceSolicitude.Add("Monto pendiente");
            HeaderCellsServiceSolicitude.Add("Monto en progreso");
            HeaderCellsServiceSolicitude.Add("Monto cancelado");
            HeaderCellsServiceSolicitude.Add("Monto cerrado");
            HeaderCellsServiceSolicitude.Add("Monto total");

            List<string> CellsServiceSolicitude = new List<string>();
            CellsServiceSolicitude.Add(numberServiceSolicitudeByState.AmountPending.ToString());
            CellsServiceSolicitude.Add(numberServiceSolicitudeByState.AmountInProgress.ToString());
            CellsServiceSolicitude.Add(numberServiceSolicitudeByState.AmountCanceled.ToString());
            CellsServiceSolicitude.Add(numberServiceSolicitudeByState.AmountClosed.ToString());
            CellsServiceSolicitude.Add(numberServiceSolicitudeByState.TotalAmount.ToString());

            
            doc.Add(CreateTable(HeaderCellsServiceSolicitude,CellsServiceSolicitude));

            doc.Add(new Paragraph(""));

            doc.Add(CreateCaption("Numero de orden de servicio"));

            List<string> headerCellsServiceOrder = new List<string>();
            headerCellsServiceOrder.Add("Monto pendiente");
            headerCellsServiceOrder.Add("Cantidad pendiente asignacion");
            headerCellsServiceOrder.Add("Monto asignado");
            headerCellsServiceOrder.Add("Monto en progreso");
            headerCellsServiceOrder.Add("Monto cancelado");
            headerCellsServiceOrder.Add("M. terminado aprovado");
            headerCellsServiceOrder.Add("M. terminado rechazado");
            headerCellsServiceOrder.Add("Monto total");

            List<string> cellsServiceOrder = new List<string>();
            cellsServiceOrder.Add(numberServiceOrderByState.AmountPending.ToString());
            cellsServiceOrder.Add(numberServiceOrderByState.AmountPendingAssignment.ToString());
            cellsServiceOrder.Add(numberServiceOrderByState.AmountAssigned.ToString());
            cellsServiceOrder.Add(numberServiceOrderByState.AmountInProgress.ToString());
            cellsServiceOrder.Add(numberServiceOrderByState.AmountCancelled.ToString());
            cellsServiceOrder.Add(numberServiceOrderByState.AmountFinishedApproved.ToString());
            cellsServiceOrder.Add(numberServiceOrderByState.AmountFinishedRejected.ToString());
            cellsServiceOrder.Add(numberServiceOrderByState.TotalAmount.ToString());

            doc.Add(CreateTable(headerCellsServiceOrder,cellsServiceOrder));

            doc.Add(new Paragraph(""));


            doc.Add(CreateCaption("Numero de veces que requieren servicio"));

            List<string> headerCellsServices = new List<string>();
            headerCellsServices.Add("#");
            headerCellsServices.Add("Nombre servicio");
            headerCellsServices.Add("Monto");

            List<string> cellsServices = new List<string>();
            int i = 1;
            foreach(var item in NumbersOfTimesTheyRequestService)
            {
                cellsServices.Add(i.ToString());
                cellsServices.Add(item.ServiceName.ToString());
                cellsServices.Add(item.Amount.ToString());
                i++;
            }

            doc.Add(CreateTable(headerCellsServices,cellsServices));


            doc.Add(new Paragraph(""));

            
            doc.Add(CreateCaption("Total pagado por cliente"));

            List<string> headerCellsCustomers = new List<string>();
            headerCellsCustomers.Add("#");
            headerCellsCustomers.Add("Nombre cliente");
            headerCellsCustomers.Add("Total generado");

            List<string> cellsCustomers = new List<string>();
            int x = 1;
            foreach (var item in totalPaidByCustomers)
            {
                cellsCustomers.Add(x.ToString());
                cellsCustomers.Add(item.CustomerName.ToString());
                cellsCustomers.Add(item.TotalGenerated.ToString());
                x++;
            }

            doc.Add(CreateTable(headerCellsCustomers, cellsCustomers));

            
            doc.Close();

            byte[] data = ms.ToArray();
            ms= new MemoryStream();
            ms.Write(data, 0, data.Length);
            ms.Position = 0;
            return new FileStreamResult(ms, "application/pdf");
        }

        public Table CreateCaption(string caption)
        {
            Table tableHeader = new Table(1).UseAllAvailableWidth();
            Cell cellHeader = new Cell().Add(new Paragraph(caption).SetFontSize(14))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER);
            tableHeader.AddCell(cellHeader);
            return tableHeader;
        }

        public Table CreateTable(List<string> headers, List<string> cells)
        {
            Style styleCell = new Style()
               .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
               .SetTextAlignment(TextAlignment.CENTER);

            Table table = new Table(headers.Count).UseAllAvailableWidth();
            Cell cell = new Cell();
            foreach (string header in headers)
            {
                cell = new Cell(2, 1).Add(new Paragraph(header));
                table.AddHeaderCell(cell.AddStyle(styleCell));
            }

            foreach (string itemCell in cells)
            {
                cell = new Cell(2, 1).Add(new Paragraph(itemCell));
                table.AddCell(cell);
            }
            return table;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}