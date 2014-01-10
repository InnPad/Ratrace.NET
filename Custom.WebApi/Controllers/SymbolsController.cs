using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Custom.Controllers
{
    using Custom.Models;

    public class SymbolsController : ApiController
    {
        private readonly Symbol[] _symbols = new[]
            {
                new  Symbol
                {
                    Id = "AAPL",
                    Name = "Apple Inc.",
                    Market = "NASDAQ",
                    Value = 459.99,
                    Summary = "Apple Inc. (Apple) designs, manufactures and markets mobile communication and media devices, personal computers, and portable digital music players, and a variety of related software, services, peripherals, networking solutions, and third-party digital content and applications. The Company's products and services include iPhone, iPad, Mac, iPod, Apple TV, a portfolio of consumer and professional software applications, the iOS and OS X operating systems, iCloud, and a variety of accessory, service and support offerings. The Company also delivers digital content and applications through the iTunes Store, App StoreSM, iBookstoreSM, and Mac App Store. The Company distributes its products worldwide through its retail stores, online stores, and direct sales force, as well as through third-party cellular network carriers, wholesalers, retailers, and value-added resellers. In February 2012, the Company acquired app-search engine Chomp."
                },
                new  Symbol
                {
                    Id = "HPQ",
                    Name = "Hewlett-Packard Company",
                    Market = "NYSE",
                    Value = 16.89,
                    Summary = "Hewlett-Packard Company (HP) is a provider of products, technologies, software, solutions and services to individual consumers, small- and medium-sized businesses (SMBs) and large enterprises, including customers in the Government, health and education sectors. Its operations are organized into seven segments: the Personal Systems Group (PSG), Services, the Imaging and Printing Group (IPG), Enterprise Servers, Storage and Networking (ESSN), HP Software, HP Financial Services (HPFS) and Corporate Investments. In March 2012, HP had consolidated PSG and IPG into a Printing and Personal Systems Group. HP continues to report the results of IPG and PSG separately. HP’s offerings include personal computing and other access devices; multi-vendor customer services, including infrastructure technology and business process outsourcing, application development and support services, and imaging and printing-related products and services. In December 2011, the Company acquired Hiflex Software GmbH."
                },
                new  Symbol
                {
                    Id = "DELL",
                    Name = "Dell Inc.",
                    Market = "NASDAQ",
                    Value = 13.81,
                    Summary = "Dell, Inc. (Dell) is a global information technology company that offers its customers a range of solutions and services delivered directly by Dell and through other distribution channels. Dell is a holding company that conducts its business worldwide through its subsidiaries. The Company operates in four segments: Large Enterprise, Public, Small and Medium Business, and Consumer. Its Large Enterprise customers include global and national corporate businesses. Its Public customers, which include educational institutions, government, health care, and law enforcement agencies, operate in their own communities. Its SMB segment is focused on helping small and medium-sized businesses by offering products, services, and solutions. Its Consumer segment is focused on delivering technology experience of entertainment, mobility, gaming, and design. In April 2012, it acquired Clerity Solutions. In September 2012, it acquired Quest Software Inc. In December 2012, it acquired Credant Technologies."
                },
                new  Symbol
                {
                    Id = "IBM",
                    Name = "International Business Machines Corp.",
                    Market = "NYSE",
                    Value = 200.32,
                    Summary = "International Business Machines Corporation (IBM) is an information technology (IT) company. IBM operates in five segments: Global Technology Services (GTS), Global Business Services (GBS), Software, Systems and Technology and Global Financing. GTS provides IT infrastructure services and business process services. GBS provides professional services and application management services. Software consists of middleware and operating systems software. Systems and Technology provides clients with business solutions requiring advanced computing power and storage capabilities. Global Financing invests in financing assets, leverages with debt and manages the associated risks. In December 2012, it acquired Kenexa. In February 2013, it completed the acquisition of StoredIQ."
                },
                new  Symbol
                {
                    Id = "GOOG",
                    Name = "Google Inc",
                    Market = "NASDAQ",
                    Value = 806.85,
                    Summary = "Google Inc. (Google) is a global technology company focused on improving the ways people connect with information. The Company generates revenue primarily by delivering online advertising. As of December 31, 2011, the Company’s business was focused on areas, such as search, advertising, operating systems and platforms, and enterprise. Businesses use its AdWords program to promote their products and services with targeted advertising. In addition, the third parties that comprise the Google Network use its AdSense program to deliver relevant advertisements that generate revenue. In June 2011, it launched Google+. In September 2011, the Company acquired Zagat. In May 2012, Google acquired Motorola Mobility Holdings, Inc. As of January 2012, over 90 million people had joined Google+. In April 2011, the Company acquired PushLife. On July 31, 2012, it acquired marketing start-up Wildfire. In September 2012, it acquired VirusTotal and Nik Software."
                },
                new  Symbol
                {
                    Id = "ACN",
                    Name = "Accenture Plc",
                    Market = "NYSE",
                    Value = 75.40,
                    Summary = "Accenture plc (Accenture) is engaged in providing management consulting, technology and outsourcing services. The Company’s business is structured around five operating groups, which together consists of 19 industry groups serving clients in industries globally. The Company’s segment includes Communications, Media & Technology, Financial Services, Health & Public Service, Products and Resources. In November 2011, the Company acquired Zenta, a provider of residential and commercial mortgage processing services in the United States. In April 2012, it acquired Neo Metrics Analytics S.L a consulting firm specializing in optimization and predictive analytics based in Madrid, Spain. On August 2, 2012, the Company acquired Octagon Research Solutions, Inc. In October 2012, it acquired the software and skills of Nokia Siemens Networks Internet Protocol television (IPTV) business. In October 2012, the Company acquired avVenta Worldwide."
                },
                new  Symbol
                {
                    Id = "NOK",
                    Name = "Nokia Corporation (ADR)",
                    Market = "NYSE",
                    Value = 3.93,
                    Summary = "Nokia Corporation (Nokia) has three operating segments: Devices & Services; NAVTEQ, and Nokia Siemens Networks. Devices & Services is responsible for developing and managing the Company’s portfolio of mobile products, as well as designing and developing services, including applications and content. NAVTEQ is a provider of digital map information and related location-based content and services for mobile navigation devices, automotive navigation systems, Internet-based mapping applications, and government and business solutions. Nokia Siemens Networks provides mobile and fixed network infrastructure, communications and networks service platforms, as well as professional services and business solutions, to operators and service providers. In August 2012, the Company sold a portfolio consisting of over 500 patents and patent applications worldwide to Vringo Inc. In November 2012, the Company acquired earthmine inc."
                },
                new  Symbol
                {
                    Id = "DIS",
                    Name = "The Walt Disney Company",
                    Market = "NYSE",
                    Value = 55.73,
                    Summary = "The Walt Disney Company, together with its subsidiaries, is a diversified worldwide entertainment company. The Company operates in five business segments: Media Networks, Parks and Resorts, Studio Entertainment, Consumer Products and Interactive. The Company has a 51% effective ownership interest in Disneyland Paris, a 5,510-acre development located in Marne-la-Vallee, approximately 20 miles east of Paris, France. The Company manages and has a 40% equity interest in Euro Disney S.C.A. The Company owns a 48% interest in Hong Kong Disneyland Resort through Hongkong International Theme Parks Limited. On November 7, 2012, the Company sold its 50% interest in ESPN STAR Sports (ESS). On November 7, 2012, the Company sold its 50% equity interest in ESPN STAR Sports (ESS). On December 21, 2012, the Company acquired Lucasfilm Ltd. LLC."
                },
                new  Symbol
                {
                    Id = "PG",
                    Name = "The Procter & Gamble Company",
                    Market = "NYSE",
                    Value = 77.38,
                    Summary = "The Procter & Gamble Company (P&G), is focused on providing consumer packaged goods. The Company’s products are sold in more than 180 countries primarily through mass merchandisers, grocery stores, membership club stores, drug stores and high-frequency stores. As of June 30, 2012, P&G was organized into two Global Business Units (GBUs): Beauty and Grooming and Household Care. The GBUs contain a total of five segments: Beauty; Grooming; Health Care; Fabric Care and Home Care and Baby Care and Family Care. Sales to Wal-Mart Stores, Inc. and the affiliates represent approximately 14% of the total revenue during the fiscal year ended June 30, 2012 (fiscal 2012). On December 30, 2011, Helen of Troy Ltd. acquired PUR water purification products business (PUR) from the Company. Effective June 1, 2012, P&G announced that it has completed the sale of the Pringles business to Kellogg Company."
                },
                new  Symbol
                {
                    Id = "TWX",
                    Name = "Time Warner Inc.",
                    Market = "NYSE",
                    Value = 53.79,
                    Summary = "Time Warner Inc. (Time Warner) is a media and entertainment company. The Company operates in three reporting segments: Networks, Filmed Entertainment and Publishing. Networks consist of television networks and premium pay and basic tier television services, which provide programming. Filmed Entertainment consists of feature film, television, home video and videogame production and distribution. Publishing consists of magazine publishing. During the year ended December 31, 2011, Home Box Office acquired an additional 8% interest in HBO Latin America Group, consisting of HBO Brasil, HBO Ole and HBO Latin America Production Services. In May 2011, the Company acquired Flixster, Inc., a social movie site. In August 2012, Turner Broadcasting System, Inc. acquired Bleacher Report."
                },
                new  Symbol
                {
                    Id = "BBRY",
                    Name = "Research In Motion Ltd",
                    Market = "NASDAQ",
                    Value = 14.35,
                    Summary = "Research In Motion Limited is a designer, manufacturer, and marketer of wireless solutions for the worldwide mobile communications market. Through the development of integrated hardware, software and services, it provides platforms and solutions for seamless access to information, including e-mail, voice, instant messaging, short message service (SMS), Internet and intranet-based applications and browsing. The Company's technology also enables an array of third party developers and manufacturers to enhance their products and services through software development kits, wireless connectivity to data and third-party support programs.Its portfolio of products, services and embedded technologies are used by thousands of organizations and millions of consumers around the world and include the BlackBerry wireless solution, the RIM Wireless Handheld product line, the BlackBerry PlayBook tablet, software development tools and other software and hardware."
                }/*,
                new  Symbol
                {
                    Id = "",
                    Name = "",
                    Market = "",
                    Value = 0,
                    Description = ""
                },*/
            };

        // GET api/symbols
        public IEnumerable<Symbol> Get()
        {
            return _symbols;
        }

        // GET api/symbols/5
        public Symbol Get(string id)
        {
            return _symbols.FirstOrDefault(o => o.Id == id);
        }
    }
}
