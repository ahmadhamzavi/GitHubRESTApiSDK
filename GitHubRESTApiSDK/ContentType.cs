using System.ComponentModel;
using System.Reflection;

namespace GitHubRESTApiSDK
{
    public enum ContentType
    {
        [Description("application/x-authorware-bin")]
        AAB,

        [Description("audio/x-aac")]
        AAC,

        [Description("application/x-authorware-map")]
        AAM,

        [Description("application/x-authorware-seg")]
        AAS,

        [Description("application/x-abiword")]
        ABW,

        [Description("application/pkix-attr-cert")]
        AC,

        [Description("application/vnd.americandynamics.acc")]
        ACC,

        [Description("application/x-ace-compressed")]
        ACE,

        [Description("application/vnd.acucobol")]
        ACU,

        [Description("application/vnd.acucorp")]
        ACUTC,

        [Description("audio/adpcm")]
        ADP,

        [Description("application/vnd.audiograph")]
        AEP,

        [Description("application/x-font-type1")]
        AFM,

        [Description("application/vnd.ibm.modcap")]
        AFP,

        [Description("application/vnd.ahead.space")]
        AHEAD,

        [Description("application/postscript")]
        AI,

        [Description("audio/x-aiff")]
        AIF,

        [Description("audio/x-aiff")]
        AIFC,

        [Description("audio/x-aiff")]
        AIFF,

        [Description("application/vnd.adobe.air-application-installer-package+zip")]
        AIR,

        [Description("application/vnd.dvb.ait")]
        AIT,

        [Description("application/vnd.amiga.ami")]
        AMI,

        [Description("application/vnd.android.package-archive")]
        APK,

        [Description("text/cache-manifest")]
        APPCACHE,

        [Description("application/x-ms-application")]
        APPLICATION,

        [Description("application/vnd.lotus-approach")]
        APR,

        [Description("application/x-freearc")]
        ARC,

        [Description("text/plain")]
        ASC,

        [Description("video/x-ms-asf")]
        ASF,

        [Description("text/x-asm")]
        ASM,

        [Description("application/vnd.accpac.simply.aso")]
        ASO,

        [Description("video/x-ms-asf")]
        ASX,

        [Description("application/vnd.acucorp")]
        ATC,

        [Description("application/atom+xml")]
        ATOM,

        [Description("application/atomcat+xml")]
        ATOMCAT,

        [Description("application/atomsvc+xml")]
        ATOMSVC,

        [Description("application/vnd.antix.game-component")]
        ATX,

        [Description("audio/basic")]
        AU,

        [Description("video/x-msvideo")]
        AVI,

        [Description("application/applixware")]
        AW,

        [Description("application/vnd.airzip.filesecure.azf")]
        AZF,

        [Description("application/vnd.airzip.filesecure.azs")]
        AZS,

        [Description("application/vnd.amazon.ebook")]
        AZW,

        [Description("application/x-msdownload")]
        BAT,

        [Description("application/x-bcpio")]
        BCPIO,

        [Description("application/x-font-bdf")]
        BDF,

        [Description("application/vnd.syncml.dm+wbxml")]
        BDM,

        [Description("application/vnd.realvnc.bed")]
        BED,

        [Description("application/vnd.fujitsu.oasysprs")]
        BH2,

        [Description("application/octet-stream")]
        BIN,

        [Description("application/x-blorb")]
        BLB,

        [Description("application/x-blorb")]
        BLORB,

        [Description("application/vnd.bmi")]
        BMI,

        [Description("image/bmp")]
        BMP,

        [Description("application/vnd.framemaker")]
        BOOK,

        [Description("application/vnd.previewsystems.box")]
        BOX,

        [Description("application/x-bzip2")]
        BOZ,

        [Description("application/octet-stream")]
        BPK,

        [Description("image/prs.btif")]
        BTIF,

        [Description("application/x-bzip")]
        BZ,

        [Description("application/x-bzip2")]
        BZ2,

        [Description("text/x-c")]
        C,

        [Description("application/vnd.cluetrust.cartomobile-config")]
        C11AMC,

        [Description("application/vnd.cluetrust.cartomobile-config-pkg")]
        C11AMZ,

        [Description("application/vnd.clonk.c4group")]
        C4D,

        [Description("application/vnd.clonk.c4group")]
        C4F,

        [Description("application/vnd.clonk.c4group")]
        C4G,

        [Description("application/vnd.clonk.c4group")]
        C4P,

        [Description("application/vnd.clonk.c4group")]
        C4U,

        [Description("application/vnd.ms-cab-compressed")]
        CAB,

        [Description("audio/x-caf")]
        CAF,

        [Description("application/vnd.tcpdump.pcap")]
        CAP,

        [Description("application/vnd.curl.car")]
        CAR,

        [Description("application/vnd.ms-pki.seccat")]
        CAT,

        [Description("application/x-cbr")]
        CB7,

        [Description("application/x-cbr")]
        CBA,

        [Description("application/x-cbr")]
        CBR,

        [Description("application/x-cbr")]
        CBT,

        [Description("application/x-cbr")]
        CBZ,

        [Description("text/x-c")]
        CC,

        [Description("application/x-director")]
        CCT,

        [Description("application/ccxml+xml")]
        CCXML,

        [Description("application/vnd.contact.cmsg")]
        CDBCMSG,

        [Description("application/x-netcdf")]
        CDF,

        [Description("application/vnd.mediastation.cdkey")]
        CDKEY,

        [Description("application/cdmi-capability")]
        CDMIA,

        [Description("application/cdmi-container")]
        CDMIC,

        [Description("application/cdmi-domain")]
        CDMID,

        [Description("application/cdmi-object")]
        CDMIO,

        [Description("application/cdmi-queue")]
        CDMIQ,

        [Description("chemical/x-cdx")]
        CDX,

        [Description("application/vnd.chemdraw+xml")]
        CDXML,

        [Description("application/vnd.cinderella")]
        CDY,

        [Description("application/pkix-cert")]
        CER,

        [Description("application/x-cfs-compressed")]
        CFS,

        [Description("image/cgm")]
        CGM,

        [Description("application/x-chat")]
        CHAT,

        [Description("application/vnd.ms-htmlhelp")]
        CHM,

        [Description("application/vnd.kde.kchart")]
        CHRT,

        [Description("chemical/x-cif")]
        CIF,

        [Description("application/vnd.anser-web-certificate-issue-initiation")]
        CII,

        [Description("application/vnd.ms-artgalry")]
        CIL,

        [Description("application/vnd.claymore")]
        CLA,

        [Description("application/java-vm")]
        CLASS,

        [Description("application/vnd.crick.clicker.keyboard")]
        CLKK,

        [Description("application/vnd.crick.clicker.palette")]
        CLKP,

        [Description("application/vnd.crick.clicker.template")]
        CLKT,

        [Description("application/vnd.crick.clicker.wordbank")]
        CLKW,

        [Description("application/vnd.crick.clicker")]
        CLKX,

        [Description("application/x-msclip")]
        CLP,

        [Description("application/vnd.cosmocaller")]
        CMC,

        [Description("chemical/x-cmdf")]
        CMDF,

        [Description("chemical/x-cml")]
        CML,

        [Description("application/vnd.yellowriver-custom-menu")]
        CMP,

        [Description("image/x-cmx")]
        CMX,

        [Description("application/vnd.rim.cod")]
        COD,

        [Description("application/x-msdownload")]
        COM,

        [Description("text/plain")]
        CONF,

        [Description("application/x-cpio")]
        CPIO,

        [Description("text/x-c")]
        CPP,

        [Description("application/mac-compactpro")]
        CPT,

        [Description("application/x-mscardfile")]
        CRD,

        [Description("application/pkix-crl")]
        CRL,

        [Description("application/x-x509-ca-cert")]
        CRT,

        [Description("application/vnd.rig.cryptonote")]
        CRYPTONOTE,

        [Description("application/x-csh")]
        CSH,

        [Description("chemical/x-csml")]
        CSML,

        [Description("application/vnd.commonspace")]
        CSP,

        [Description("text/css")]
        CSS,

        [Description("application/x-director")]
        CST,

        [Description("text/csv")]
        CSV,

        [Description("application/cu-seeme")]
        CU,

        [Description("text/vnd.curl")]
        CURL,

        [Description("application/prs.cww")]
        CWW,

        [Description("application/x-director")]
        CXT,

        [Description("text/x-c")]
        CXX,

        [Description("model/vnd.collada+xml")]
        DAE,

        [Description("application/vnd.mobius.daf")]
        DAF,

        [Description("application/vnd.dart")]
        DART,

        [Description("application/vnd.fdsn.seed")]
        DATALESS,

        [Description("application/davmount+xml")]
        DAVMOUNT,

        [Description("application/docbook+xml")]
        DBK,

        [Description("application/x-director")]
        DCR,

        [Description("text/vnd.curl.dcurl")]
        DCURL,

        [Description("application/vnd.oma.dd2+xml")]
        DD2,

        [Description("application/vnd.fujixerox.ddd")]
        DDD,

        [Description("application/x-debian-package")]
        DEB,

        [Description("text/plain")]
        DEF,

        [Description("application/octet-stream")]
        DEPLOY,

        [Description("application/x-x509-ca-cert")]
        DER,

        [Description("application/vnd.dreamfactory")]
        DFAC,

        [Description("application/x-dgc-compressed")]
        DGC,

        [Description("text/x-c")]
        DIC,

        [Description("video/x-dv")]
        DIF,

        [Description("application/x-director")]
        DIR,

        [Description("application/vnd.mobius.dis")]
        DIS,

        [Description("application/octet-stream")]
        DIST,

        [Description("application/octet-stream")]
        DISTZ,

        [Description("image/vnd.djvu")]
        DJV,

        [Description("image/vnd.djvu")]
        DJVU,

        [Description("application/x-msdownload")]
        DLL,

        [Description("application/x-apple-diskimage")]
        DMG,

        [Description("application/vnd.tcpdump.pcap")]
        DMP,

        [Description("application/octet-stream")]
        DMS,

        [Description("application/vnd.dna")]
        DNA,

        [Description("application/msword")]
        DOC,

        [Description("application/vnd.ms-word.document.macroenabled.12")]
        DOCM,

        [Description("application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        DOCX,

        [Description("application/msword")]
        DOT,

        [Description("application/vnd.ms-word.template.macroenabled.12")]
        DOTM,

        [Description("application/vnd.openxmlformats-officedocument.wordprocessingml.template")]
        DOTX,

        [Description("application/vnd.osgi.dp")]
        DP,

        [Description("application/vnd.dpgraph")]
        DPG,

        [Description("audio/vnd.dra")]
        DRA,

        [Description("text/prs.lines.tag")]
        DSC,

        [Description("application/dssc+der")]
        DSSC,

        [Description("application/x-dtbook+xml")]
        DTB,

        [Description("application/xml-dtd")]
        DTD,

        [Description("audio/vnd.dts")]
        DTS,

        [Description("audio/vnd.dts.hd")]
        DTSHD,

        [Description("application/octet-stream")]
        DUMP,

        [Description("video/x-dv")]
        DV,

        [Description("video/vnd.dvb.file")]
        DVB,

        [Description("application/x-dvi")]
        DVI,

        [Description("model/vnd.dwf")]
        DWF,

        [Description("image/vnd.dwg")]
        DWG,

        [Description("image/vnd.dxf")]
        DXF,

        [Description("application/vnd.spotfire.dxp")]
        DXP,

        [Description("application/x-director")]
        DXR,

        [Description("audio/vnd.nuera.ecelp4800")]
        ECELP4800,

        [Description("audio/vnd.nuera.ecelp7470")]
        ECELP7470,

        [Description("audio/vnd.nuera.ecelp9600")]
        ECELP9600,

        [Description("application/ecmascript")]
        ECMA,

        [Description("application/vnd.novadigm.edm")]
        EDM,

        [Description("application/vnd.novadigm.edx")]
        EDX,

        [Description("application/vnd.picsel")]
        EFIF,

        [Description("application/vnd.pg.osasli")]
        EI6,

        [Description("application/octet-stream")]
        ELC,

        [Description("application/x-msmetafile")]
        EMF,

        [Description("message/rfc822")]
        EML,

        [Description("application/emma+xml")]
        EMMA,

        [Description("application/x-msmetafile")]
        EMZ,

        [Description("audio/vnd.digital-winds")]
        EOL,

        [Description("application/vnd.ms-fontobject")]
        EOT,

        [Description("application/postscript")]
        EPS,

        [Description("application/epub+zip")]
        EPUB,

        [Description("application/vnd.eszigno3+xml")]
        ES3,

        [Description("application/vnd.osgi.subsystem")]
        ESA,

        [Description("application/vnd.epson.esf")]
        ESF,

        [Description("application/vnd.eszigno3+xml")]
        ET3,

        [Description("text/x-setext")]
        ETX,

        [Description("application/x-eva")]
        EVA,

        [Description("application/x-envoy")]
        EVY,

        [Description("application/x-msdownload")]
        EXE,

        [Description("application/exi")]
        EXI,

        [Description("application/vnd.novadigm.ext")]
        EXT,

        [Description("MIME type (lowercased)")]
        EXTENSIONS,

        [Description("application/andrew-inset")]
        EZ,

        [Description("application/vnd.ezpix-album")]
        EZ2,

        [Description("application/vnd.ezpix-package")]
        EZ3,

        [Description("text/x-fortran")]
        F,

        [Description("video/x-f4v")]
        F4V,

        [Description("text/x-fortran")]
        F77,

        [Description("text/x-fortran")]
        F90,

        [Description("image/vnd.fastbidsheet")]
        FBS,

        [Description("application/vnd.adobe.formscentral.fcdt")]
        FCDT,

        [Description("application/vnd.isac.fcs")]
        FCS,

        [Description("application/vnd.fdf")]
        FDF,

        [Description("application/vnd.denovo.fcselayout-link")]
        FE_LAUNCH,

        [Description("application/vnd.fujitsu.oasysgp")]
        FG5,

        [Description("application/x-director")]
        FGD,

        [Description("image/x-freehand")]
        FH,

        [Description("image/x-freehand")]
        FH4,

        [Description("image/x-freehand")]
        FH5,

        [Description("image/x-freehand")]
        FH7,

        [Description("image/x-freehand")]
        FHC,

        [Description("application/x-xfig")]
        FIG,

        [Description("audio/x-flac")]
        FLAC,

        [Description("video/x-fli")]
        FLI,

        [Description("application/vnd.micrografx.flo")]
        FLO,

        [Description("video/x-flv")]
        FLV,

        [Description("application/vnd.kde.kivio")]
        FLW,

        [Description("text/vnd.fmi.flexstor")]
        FLX,

        [Description("text/vnd.fly")]
        FLY,

        [Description("application/vnd.framemaker")]
        FM,

        [Description("application/vnd.frogans.fnc")]
        FNC,

        [Description("text/x-fortran")]
        FOR,

        [Description("image/vnd.fpx")]
        FPX,

        [Description("application/vnd.framemaker")]
        FRAME,

        [Description("application/vnd.fsc.weblaunch")]
        FSC,

        [Description("image/vnd.fst")]
        FST,

        [Description("application/vnd.fluxtime.clip")]
        FTC,

        [Description("application/vnd.anser-web-funds-transfer-initiation")]
        FTI,

        [Description("video/vnd.fvt")]
        FVT,

        [Description("application/vnd.adobe.fxp")]
        FXP,

        [Description("application/vnd.adobe.fxp")]
        FXPL,

        [Description("application/vnd.fuzzysheet")]
        FZS,

        [Description("application/vnd.geoplan")]
        G2W,

        [Description("image/g3fax")]
        G3,

        [Description("application/vnd.geospace")]
        G3W,

        [Description("application/vnd.groove-account")]
        GAC,

        [Description("application/x-tads")]
        GAM,

        [Description("application/rpki-ghostbusters")]
        GBR,

        [Description("application/x-gca-compressed")]
        GCA,

        [Description("model/vnd.gdl")]
        GDL,

        [Description("application/vnd.dynageo")]
        GEO,

        [Description("application/vnd.geometry-explorer")]
        GEX,

        [Description("application/vnd.geogebra.file")]
        GGB,

        [Description("application/vnd.geogebra.tool")]
        GGT,

        [Description("application/vnd.groove-help")]
        GHF,

        [Description("image/gif")]
        GIF,

        [Description("application/vnd.groove-identity-message")]
        GIM,

        [Description("application/gml+xml")]
        GML,

        [Description("application/vnd.gmx")]
        GMX,

        [Description("application/x-gnumeric")]
        GNUMERIC,

        [Description("application/vnd.flographit")]
        GPH,

        [Description("application/gpx+xml")]
        GPX,

        [Description("application/vnd.grafeq")]
        GQF,

        [Description("application/vnd.grafeq")]
        GQS,

        [Description("application/srgs")]
        GRAM,

        [Description("application/x-gramps-xml")]
        GRAMPS,

        [Description("application/vnd.geometry-explorer")]
        GRE,

        [Description("application/vnd.groove-injector")]
        GRV,

        [Description("application/srgs+xml")]
        GRXML,

        [Description("application/x-font-ghostscript")]
        GSF,

        [Description("application/x-gtar")]
        GTAR,

        [Description("application/vnd.groove-tool-message")]
        GTM,

        [Description("model/vnd.gtw")]
        GTW,

        [Description("text/vnd.graphviz")]
        GV,

        [Description("application/gxf")]
        GXF,

        [Description("application/vnd.geonext")]
        GXT,

        [Description("text/x-c")]
        H,

        [Description("video/h261")]
        H261,

        [Description("video/h263")]
        H263,

        [Description("video/h264")]
        H264,

        [Description("application/vnd.hal+xml")]
        HAL,

        [Description("application/vnd.hbci")]
        HBCI,

        [Description("application/x-hdf")]
        HDF,

        [Description("text/x-c")]
        HH,

        [Description("application/winhlp")]
        HLP,

        [Description("application/vnd.hp-hpgl")]
        HPGL,

        [Description("application/vnd.hp-hpid")]
        HPID,

        [Description("application/vnd.hp-hps")]
        HPS,

        [Description("application/mac-binhex40")]
        HQX,

        [Description("application/vnd.kenameaapp")]
        HTKE,

        [Description("text/html")]
        HTM,

        [Description("text/html")]
        HTML,

        [Description("application/vnd.yamaha.hv-dic")]
        HVD,

        [Description("application/vnd.yamaha.hv-voice")]
        HVP,

        [Description("application/vnd.yamaha.hv-script")]
        HVS,

        [Description("application/vnd.intergeo")]
        I2G,

        [Description("x-conference/x-cooltalk")]
        IC,

        [Description("application/vnd.iccprofile")]
        ICC,

        [Description("x-conference/x-cooltalk")]
        ICE,

        [Description("application/vnd.iccprofile")]
        ICM,

        [Description("image/x-icon")]
        ICO,

        [Description("text/calendar")]
        ICS,

        [Description("image/ief")]
        IEF,

        [Description("text/calendar")]
        IFB,

        [Description("application/vnd.shana.informed.formdata")]
        IFM,

        [Description("model/iges")]
        IGES,

        [Description("application/vnd.igloader")]
        IGL,

        [Description("application/vnd.insors.igm")]
        IGM,

        [Description("model/iges")]
        IGS,

        [Description("application/vnd.micrografx.igx")]
        IGX,

        [Description("application/vnd.shana.informed.interchange")]
        IIF,

        [Description("application/vnd.accpac.simply.imp")]
        IMP,

        [Description("application/vnd.ms-ims")]
        IMS,

        [Description("text/plain")]
        IN,

        [Description("application/inkml+xml")]
        INK,

        [Description("application/inkml+xml")]
        INKML,

        [Description("application/x-install-instructions")]
        INSTALL,

        [Description("application/vnd.astraea-software.iota")]
        IOTA,

        [Description("application/ipfix")]
        IPFIX,

        [Description("application/vnd.shana.informed.package")]
        IPK,

        [Description("application/vnd.ibm.rights-management")]
        IRM,

        [Description("application/vnd.irepository.package+xml")]
        IRP,

        [Description("application/x-iso9660-image")]
        ISO,

        [Description("application/vnd.shana.informed.formtemplate")]
        ITP,

        [Description("application/vnd.immervision-ivp")]
        IVP,

        [Description("application/vnd.immervision-ivu")]
        IVU,

        [Description("text/vnd.sun.j2me.app-descriptor")]
        JAD,

        [Description("application/vnd.jam")]
        JAM,

        [Description("application/java-archive")]
        JAR,

        [Description("text/x-java-source")]
        JAVA,

        [Description("application/vnd.jisp")]
        JISP,

        [Description("application/vnd.hp-jlyt")]
        JLT,

        [Description("application/x-java-jnlp-file")]
        JNLP,

        [Description("application/vnd.joost.joda-archive")]
        JODA,

        [Description("image/jp2")]
        JP2,

        [Description("image/jpeg")]
        JPE,

        [Description("image/jpeg")]
        JPEG,

        [Description("image/jpeg")]
        JPG,

        [Description("video/jpm")]
        JPGM,

        [Description("video/jpeg")]
        JPGV,

        [Description("video/jpm")]
        JPM,

        [Description("application/javascript")]
        JS,

        [Description("application/json")]
        JSON,

        [Description("application/jsonml+json")]
        JSONML,

        [Description("audio/midi")]
        KAR,

        [Description("application/vnd.kde.karbon")]
        KARBON,

        [Description("application/vnd.kde.kformula")]
        KFO,

        [Description("application/vnd.kidspiration")]
        KIA,

        [Description("application/vnd.google-earth.kml+xml")]
        KML,

        [Description("application/vnd.google-earth.kmz")]
        KMZ,

        [Description("application/vnd.kinar")]
        KNE,

        [Description("application/vnd.kinar")]
        KNP,

        [Description("application/vnd.kde.kontour")]
        KON,

        [Description("application/vnd.kde.kpresenter")]
        KPR,

        [Description("application/vnd.kde.kpresenter")]
        KPT,

        [Description("application/vnd.ds-keypoint")]
        KPXX,

        [Description("application/vnd.kde.kspread")]
        KSP,

        [Description("application/vnd.kahootz")]
        KTR,

        [Description("image/ktx")]
        KTX,

        [Description("application/vnd.kahootz")]
        KTZ,

        [Description("application/vnd.kde.kword")]
        KWD,

        [Description("application/vnd.kde.kword")]
        KWT,

        [Description("application/vnd.las.las+xml")]
        LASXML,

        [Description("application/x-latex")]
        LATEX,

        [Description("application/vnd.llamagraphics.life-balance.desktop")]
        LBD,

        [Description("application/vnd.llamagraphics.life-balance.exchange+xml")]
        LBE,

        [Description("application/vnd.hhe.lesson-player")]
        LES,

        [Description("application/x-lzh-compressed")]
        LHA,

        [Description("application/vnd.route66.link66+xml")]
        LINK66,

        [Description("text/plain")]
        LIST,

        [Description("application/vnd.ibm.modcap")]
        LIST3820,

        [Description("application/vnd.ibm.modcap")]
        LISTAFP,

        [Description("application/x-ms-shortcut")]
        LNK,

        [Description("text/plain")]
        LOG,

        [Description("application/lost+xml")]
        LOSTXML,

        [Description("application/octet-stream")]
        LRF,

        [Description("application/vnd.ms-lrm")]
        LRM,

        [Description("application/vnd.frogans.ltf")]
        LTF,

        [Description("audio/vnd.lucent.voice")]
        LVP,

        [Description("application/vnd.lotus-wordpro")]
        LWP,

        [Description("application/x-lzh-compressed")]
        LZH,

        [Description("application/x-msmediaview")]
        M13,

        [Description("application/x-msmediaview")]
        M14,

        [Description("video/mpeg")]
        M1V,

        [Description("application/mp21")]
        M21,

        [Description("audio/mpeg")]
        M2A,

        [Description("video/mpeg")]
        M2V,

        [Description("audio/mpeg")]
        M3A,

        [Description("audio/x-mpegurl")]
        M3U,

        [Description("application/vnd.apple.mpegurl")]
        M3U8,

        [Description("audio/mp4a-latm")]
        M4A,

        [Description("audio/mp4a-latm")]
        M4B,

        [Description("audio/mp4a-latm")]
        M4P,

        [Description("video/vnd.mpegurl")]
        M4U,

        [Description("video/x-m4v")]
        M4V,

        [Description("application/mathematica")]
        MA,

        [Description("image/x-macpaint")]
        MAC,

        [Description("application/mads+xml")]
        MADS,

        [Description("application/vnd.ecowin.chart")]
        MAG,

        [Description("application/vnd.framemaker")]
        MAKER,

        [Description("application/x-troff-man")]
        MAN,

        [Description("application/octet-stream")]
        MAR,

        [Description("application/mathml+xml")]
        MATHML,

        [Description("application/mathematica")]
        MB,

        [Description("application/vnd.mobius.mbk")]
        MBK,

        [Description("application/mbox")]
        MBOX,

        [Description("application/vnd.medcalcdata")]
        MC1,

        [Description("application/vnd.mcd")]
        MCD,

        [Description("text/vnd.curl.mcurl")]
        MCURL,

        [Description("application/x-msaccess")]
        MDB,

        [Description("image/vnd.ms-modi")]
        MDI,

        [Description("application/x-troff-me")]
        ME,

        [Description("model/mesh")]
        MESH,

        [Description("application/metalink4+xml")]
        META4,

        [Description("application/metalink+xml")]
        METALINK,

        [Description("application/mets+xml")]
        METS,

        [Description("application/vnd.mfmp")]
        MFM,

        [Description("application/rpki-manifest")]
        MFT,

        [Description("application/vnd.osgeo.mapguide.package")]
        MGP,

        [Description("application/vnd.proteus.magazine")]
        MGZ,

        [Description("audio/midi")]
        MID,

        [Description("audio/midi")]
        MIDI,

        [Description("application/x-mie")]
        MIE,

        [Description("application/vnd.mif")]
        MIF,

        [Description("message/rfc822")]
        MIME,

        [Description("video/mj2")]
        MJ2,

        [Description("video/mj2")]
        MJP2,

        [Description("video/x-matroska")]
        MK3D,

        [Description("audio/x-matroska")]
        MKA,

        [Description("video/x-matroska")]
        MKS,

        [Description("video/x-matroska")]
        MKV,

        [Description("application/vnd.dolby.mlp")]
        MLP,

        [Description("application/vnd.chipnuts.karaoke-mmd")]
        MMD,

        [Description("application/vnd.smaf")]
        MMF,

        [Description("image/vnd.fujixerox.edmics-mmr")]
        MMR,

        [Description("video/x-mng")]
        MNG,

        [Description("application/x-msmoney")]
        MNY,

        [Description("application/x-mobipocket-ebook")]
        MOBI,

        [Description("application/mods+xml")]
        MODS,

        [Description("video/quicktime")]
        MOV,

        [Description("video/x-sgi-movie")]
        MOVIE,

        [Description("audio/mpeg")]
        MP2,

        [Description("application/mp21")]
        MP21,

        [Description("audio/mpeg")]
        MP2A,

        [Description("audio/mpeg")]
        MP3,

        [Description("video/mp4")]
        MP4,

        [Description("audio/mp4")]
        MP4A,

        [Description("application/mp4")]
        MP4S,

        [Description("video/mp4")]
        MP4V,

        [Description("application/vnd.mophun.certificate")]
        MPC,

        [Description("video/mpeg")]
        MPE,

        [Description("video/mpeg")]
        MPEG,

        [Description("video/mpeg")]
        MPG,

        [Description("video/mp4")]
        MPG4,

        [Description("audio/mpeg")]
        MPGA,

        [Description("application/vnd.apple.installer+xml")]
        MPKG,

        [Description("application/vnd.blueice.multipass")]
        MPM,

        [Description("application/vnd.mophun.application")]
        MPN,

        [Description("application/vnd.ms-project")]
        MPP,

        [Description("application/vnd.ms-project")]
        MPT,

        [Description("application/vnd.ibm.minipay")]
        MPY,

        [Description("application/vnd.mobius.mqy")]
        MQY,

        [Description("application/marc")]
        MRC,

        [Description("application/marcxml+xml")]
        MRCX,

        [Description("application/x-troff-ms")]
        MS,

        [Description("application/mediaservercontrol+xml")]
        MSCML,

        [Description("application/vnd.fdsn.mseed")]
        MSEED,

        [Description("application/vnd.mseq")]
        MSEQ,

        [Description("application/vnd.epson.msf")]
        MSF,

        [Description("model/mesh")]
        MSH,

        [Description("application/x-msdownload")]
        MSI,

        [Description("application/vnd.mobius.msl")]
        MSL,

        [Description("application/vnd.muvee.style")]
        MSTY,

        [Description("model/vnd.mts")]
        MTS,

        [Description("application/vnd.musician")]
        MUS,

        [Description("application/vnd.recordare.musicxml+xml")]
        MUSICXML,

        [Description("application/x-msmediaview")]
        MVB,

        [Description("application/vnd.mfer")]
        MWF,

        [Description("application/mxf")]
        MXF,

        [Description("application/vnd.recordare.musicxml")]
        MXL,

        [Description("application/xv+xml")]
        MXML,

        [Description("application/vnd.triscape.mxs")]
        MXS,

        [Description("video/vnd.mpegurl")]
        MXU,

        [Description("text/n3")]
        N3,

        [Description("application/mathematica")]
        NB,

        [Description("application/vnd.wolfram.player")]
        NBP,

        [Description("application/x-netcdf")]
        NC,

        [Description("application/x-dtbncx+xml")]
        NCX,

        [Description("text/x-nfo")]
        NFO,

        [Description("application/vnd.nokia.n-gage.data")]
        NGDAT,

        [Description("application/vnd.nitf")]
        NITF,

        [Description("application/vnd.neurolanguage.nlu")]
        NLU,

        [Description("application/vnd.enliven")]
        NML,

        [Description("application/vnd.noblenet-directory")]
        NND,

        [Description("application/vnd.noblenet-sealer")]
        NNS,

        [Description("application/vnd.noblenet-web")]
        NNW,

        [Description("image/vnd.net-fpx")]
        NPX,

        [Description("application/x-conference")]
        NSC,

        [Description("application/vnd.lotus-notes")]
        NSF,

        [Description("application/vnd.nitf")]
        NTF,

        [Description("application/x-nzb")]
        NZB,

        [Description("application/vnd.fujitsu.oasys2")]
        OA2,

        [Description("application/vnd.fujitsu.oasys3")]
        OA3,

        [Description("application/vnd.fujitsu.oasys")]
        OAS,

        [Description("application/x-msbinder")]
        OBD,

        [Description("application/x-tgif")]
        OBJ,

        [Description("application/oda")]
        ODA,

        [Description("application/vnd.oasis.opendocument.database")]
        ODB,

        [Description("application/vnd.oasis.opendocument.chart")]
        ODC,

        [Description("application/vnd.oasis.opendocument.formula")]
        ODF,

        [Description("application/vnd.oasis.opendocument.formula-template")]
        ODFT,

        [Description("application/vnd.oasis.opendocument.graphics")]
        ODG,

        [Description("application/vnd.oasis.opendocument.image")]
        ODI,

        [Description("application/vnd.oasis.opendocument.text-master")]
        ODM,

        [Description("application/vnd.oasis.opendocument.presentation")]
        ODP,

        [Description("application/vnd.oasis.opendocument.spreadsheet")]
        ODS,

        [Description("application/vnd.oasis.opendocument.text")]
        ODT,

        [Description("audio/ogg")]
        OGA,

        [Description("video/ogg")]
        OGG,

        [Description("video/ogg")]
        OGV,

        [Description("application/ogg")]
        OGX,

        [Description("application/omdoc+xml")]
        OMDOC,

        [Description("application/onenote")]
        ONEPKG,

        [Description("application/onenote")]
        ONETMP,

        [Description("application/onenote")]
        ONETOC,

        [Description("application/onenote")]
        ONETOC2,

        [Description("application/oebps-package+xml")]
        OPF,

        [Description("text/x-opml")]
        OPML,

        [Description("application/vnd.palm")]
        OPRC,

        [Description("application/vnd.lotus-organizer")]
        ORG,

        [Description("application/vnd.yamaha.openscoreformat")]
        OSF,

        [Description("application/vnd.yamaha.openscoreformat.osfpvg+xml")]
        OSFPVG,

        [Description("application/vnd.oasis.opendocument.chart-template")]
        OTC,

        [Description("application/x-font-otf")]
        OTF,

        [Description("application/vnd.oasis.opendocument.graphics-template")]
        OTG,

        [Description("application/vnd.oasis.opendocument.text-web")]
        OTH,

        [Description("application/vnd.oasis.opendocument.image-template")]
        OTI,

        [Description("application/vnd.oasis.opendocument.presentation-template")]
        OTP,

        [Description("application/vnd.oasis.opendocument.spreadsheet-template")]
        OTS,

        [Description("application/vnd.oasis.opendocument.text-template")]
        OTT,

        [Description("application/oxps")]
        OXPS,

        [Description("application/vnd.openofficeorg.extension")]
        OXT,

        [Description("text/x-pascal")]
        P,

        [Description("application/pkcs10")]
        P10,

        [Description("application/x-pkcs12")]
        P12,

        [Description("application/x-pkcs7-certificates")]
        P7B,

        [Description("application/pkcs7-mime")]
        P7C,

        [Description("application/pkcs7-mime")]
        P7M,

        [Description("application/x-pkcs7-certreqresp")]
        P7R,

        [Description("application/pkcs7-signature")]
        P7S,

        [Description("application/pkcs8")]
        P8,

        [Description("text/x-pascal")]
        PAS,

        [Description("application/vnd.pawaafile")]
        PAW,

        [Description("application/vnd.powerbuilder6")]
        PBD,

        [Description("image/x-portable-bitmap")]
        PBM,

        [Description("application/vnd.tcpdump.pcap")]
        PCAP,

        [Description("application/x-font-pcf")]
        PCF,

        [Description("application/vnd.hp-pcl")]
        PCL,

        [Description("application/vnd.hp-pclxl")]
        PCLXL,

        [Description("image/x-pict")]
        PCT,

        [Description("application/vnd.curl.pcurl")]
        PCURL,

        [Description("image/x-pcx")]
        PCX,

        [Description("applicaton/octet-stream")]
        PDB,

        [Description("application/pdf")]
        PDF,

        [Description("application/x-font-type1")]
        PFA,

        [Description("application/x-font-type1")]
        PFB,

        [Description("application/x-font-type1")]
        PFM,

        [Description("application/font-tdpfr")]
        PFR,

        [Description("application/x-pkcs12")]
        PFX,

        [Description("image/x-portable-graymap")]
        PGM,

        [Description("application/x-chess-pgn")]
        PGN,

        [Description("application/pgp-encrypted")]
        PGP,

        [Description("image/x-pict")]
        PIC,

        [Description("image/pict")]
        PICT,

        [Description("application/octet-stream")]
        PKG,

        [Description("application/pkixcmp")]
        PKI,

        [Description("application/pkix-pkipath")]
        PKIPATH,

        [Description("application/vnd.3gpp.pic-bw-large")]
        PLB,

        [Description("application/vnd.mobius.plc")]
        PLC,

        [Description("application/vnd.pocketlearn")]
        PLF,

        [Description("application/pls+xml")]
        PLS,

        [Description("application/vnd.ctc-posml")]
        PML,

        [Description("image/png")]
        PNG,

        [Description("image/x-portable-anymap")]
        PNM,

        [Description("image/x-macpaint")]
        PNT,

        [Description("image/x-macpaint")]
        PNTG,

        [Description("application/vnd.macports.portpkg")]
        PORTPKG,

        [Description("application/vnd.ms-powerpoint")]
        POT,

        [Description("application/vnd.ms-powerpoint.template.macroenabled.12")]
        POTM,

        [Description("application/vnd.openxmlformats-officedocument.presentationml.template")]
        POTX,

        [Description("application/vnd.ms-powerpoint.addin.macroenabled.12")]
        PPAM,

        [Description("application/vnd.cups-ppd")]
        PPD,

        [Description("image/x-portable-pixmap")]
        PPM,

        [Description("application/vnd.ms-powerpoint")]
        PPS,

        [Description("application/vnd.ms-powerpoint.slideshow.macroenabled.12")]
        PPSM,

        [Description("application/vnd.openxmlformats-officedocument.presentationml.slideshow")]
        PPSX,

        [Description("application/vnd.ms-powerpoint")]
        PPT,

        [Description("application/vnd.ms-powerpoint.presentation.macroenabled.12")]
        PPTM,

        [Description("application/vnd.openxmlformats-officedocument.presentationml.presentation")]
        PPTX,

        [Description("application/vnd.palm")]
        PQA,

        [Description("application/x-mobipocket-ebook")]
        PRC,

        [Description("application/vnd.lotus-freelance")]
        PRE,

        [Description("application/pics-rules")]
        PRF,

        [Description("application/postscript")]
        PS,

        [Description("application/vnd.3gpp.pic-bw-small")]
        PSB,

        [Description("image/vnd.adobe.photoshop")]
        PSD,

        [Description("application/x-font-linux-psf")]
        PSF,

        [Description("application/pskc+xml")]
        PSKCXML,

        [Description("application/vnd.pvi.ptid1")]
        PTID,

        [Description("application/x-mspublisher")]
        PUB,

        [Description("application/vnd.3gpp.pic-bw-var")]
        PVB,

        [Description("application/vnd.3m.post-it-notes")]
        PWN,

        [Description("audio/vnd.ms-playready.media.pya")]
        PYA,

        [Description("video/vnd.ms-playready.media.pyv")]
        PYV,

        [Description("application/vnd.epson.quickanime")]
        QAM,

        [Description("application/vnd.intu.qbo")]
        QBO,

        [Description("application/vnd.intu.qfx")]
        QFX,

        [Description("application/vnd.publishare-delta-tree")]
        QPS,

        [Description("video/quicktime")]
        QT,

        [Description("image/x-quicktime")]
        QTI,

        [Description("image/x-quicktime")]
        QTIF,

        [Description("application/vnd.quark.quarkxpress")]
        QWD,

        [Description("application/vnd.quark.quarkxpress")]
        QWT,

        [Description("application/vnd.quark.quarkxpress")]
        QXB,

        [Description("application/vnd.quark.quarkxpress")]
        QXD,

        [Description("application/vnd.quark.quarkxpress")]
        QXL,

        [Description("application/vnd.quark.quarkxpress")]
        QXT,

        [Description("audio/x-pn-realaudio")]
        RA,

        [Description("audio/x-pn-realaudio")]
        RAM,

        [Description("application/x-rar-compressed")]
        RAR,

        [Description("image/x-cmu-raster")]
        RAS,

        [Description("application/vnd.ipunplugged.rcprofile")]
        RCPROFILE,

        [Description("application/rdf+xml")]
        RDF,

        [Description("application/vnd.data-vision.rdz")]
        RDZ,

        [Description("application/vnd.businessobjects")]
        REP,

        [Description("application/x-dtbresource+xml")]
        RES,

        [Description("image/x-rgb")]
        RGB,

        [Description("application/reginfo+xml")]
        RIF,

        [Description("audio/vnd.rip")]
        RIP,

        [Description("application/x-research-info-systems")]
        RIS,

        [Description("application/resource-lists+xml")]
        RL,

        [Description("image/vnd.fujixerox.edmics-rlc")]
        RLC,

        [Description("application/resource-lists-diff+xml")]
        RLD,

        [Description("application/vnd.rn-realmedia")]
        RM,

        [Description("audio/midi")]
        RMI,

        [Description("audio/x-pn-realaudio-plugin")]
        RMP,

        [Description("application/vnd.jcp.javame.midlet-rms")]
        RMS,

        [Description("application/vnd.rn-realmedia-vbr")]
        RMVB,

        [Description("application/relax-ng-compact-syntax")]
        RNC,

        [Description("application/rpki-roa")]
        ROA,

        [Description("application/x-troff")]
        ROFF,

        [Description("application/vnd.cloanto.rp9")]
        RP9,

        [Description("application/vnd.nokia.radio-presets")]
        RPSS,

        [Description("application/vnd.nokia.radio-preset")]
        RPST,

        [Description("application/sparql-query")]
        RQ,

        [Description("application/rls-services+xml")]
        RS,

        [Description("application/rsd+xml")]
        RSD,

        [Description("application/rss+xml")]
        RSS,

        [Description("application/rtf")]
        RTF,

        [Description("text/richtext")]
        RTX,

        [Description("text/x-asm")]
        S,

        [Description("audio/s3m")]
        S3M,

        [Description("application/vnd.yamaha.smaf-audio")]
        SAF,

        [Description("application/sbml+xml")]
        SBML,

        [Description("application/vnd.ibm.secure-container")]
        SC,

        [Description("application/x-msschedule")]
        SCD,

        [Description("application/vnd.lotus-screencam")]
        SCM,

        [Description("application/scvp-cv-request")]
        SCQ,

        [Description("application/scvp-cv-response")]
        SCS,

        [Description("text/vnd.curl.scurl")]
        SCURL,

        [Description("application/vnd.stardivision.draw")]
        SDA,

        [Description("application/vnd.stardivision.calc")]
        SDC,

        [Description("application/vnd.stardivision.impress")]
        SDD,

        [Description("application/vnd.solent.sdkm+xml")]
        SDKD,

        [Description("application/vnd.solent.sdkm+xml")]
        SDKM,

        [Description("application/sdp")]
        SDP,

        [Description("application/vnd.stardivision.writer")]
        SDW,

        [Description("application/vnd.seemail")]
        SEE,

        [Description("application/vnd.fdsn.seed")]
        SEED,

        [Description("application/vnd.sema")]
        SEMA,

        [Description("application/vnd.semd")]
        SEMD,

        [Description("application/vnd.semf")]
        SEMF,

        [Description("application/java-serialized-object")]
        SER,

        [Description("application/set-payment-initiation")]
        SETPAY,

        [Description("application/set-registration-initiation")]
        SETREG,

        [Description("application/vnd.spotfire.sfs")]
        SFS,

        [Description("text/x-sfv")]
        SFV,

        [Description("image/sgi")]
        SGI,

        [Description("application/vnd.stardivision.writer-global")]
        SGL,

        [Description("text/sgml")]
        SGM,

        [Description("text/sgml")]
        SGML,

        [Description("application/x-sh")]
        SH,

        [Description("application/x-shar")]
        SHAR,

        [Description("application/shf+xml")]
        SHF,

        [Description("image/x-mrsid-image")]
        SID,

        [Description("application/pgp-signature")]
        SIG,

        [Description("audio/silk")]
        SIL,

        [Description("model/mesh")]
        SILO,

        [Description("application/vnd.symbian.install")]
        SIS,

        [Description("application/vnd.symbian.install")]
        SISX,

        [Description("application/x-stuffit")]
        SIT,

        [Description("application/x-stuffitx")]
        SITX,

        [Description("application/x-koan")]
        SKD,

        [Description("application/x-koan")]
        SKM,

        [Description("application/x-koan")]
        SKP,

        [Description("application/x-koan")]
        SKT,

        [Description("application/vnd.ms-powerpoint.slide.macroenabled.12")]
        SLDM,

        [Description("application/vnd.openxmlformats-officedocument.presentationml.slide")]
        SLDX,

        [Description("application/vnd.epson.salt")]
        SLT,

        [Description("application/vnd.stepmania.stepchart")]
        SM,

        [Description("application/vnd.stardivision.math")]
        SMF,

        [Description("application/smil+xml")]
        SMI,

        [Description("application/smil+xml")]
        SMIL,

        [Description("video/x-smv")]
        SMV,

        [Description("application/vnd.stepmania.package")]
        SMZIP,

        [Description("audio/basic")]
        SND,

        [Description("application/x-font-snf")]
        SNF,

        [Description("application/octet-stream")]
        SO,

        [Description("application/x-pkcs7-certificates")]
        SPC,

        [Description("application/vnd.yamaha.smaf-phrase")]
        SPF,

        [Description("application/x-futuresplash")]
        SPL,

        [Description("text/vnd.in3d.spot")]
        SPOT,

        [Description("application/scvp-vp-response")]
        SPP,

        [Description("application/scvp-vp-request")]
        SPQ,

        [Description("audio/ogg")]
        SPX,

        [Description("application/x-sql")]
        SQL,

        [Description("application/x-wais-source")]
        SRC,

        [Description("application/x-subrip")]
        SRT,

        [Description("application/sru+xml")]
        SRU,

        [Description("application/sparql-results+xml")]
        SRX,

        [Description("application/ssdl+xml")]
        SSDL,

        [Description("application/vnd.kodak-descriptor")]
        SSE,

        [Description("application/vnd.epson.ssf")]
        SSF,

        [Description("application/ssml+xml")]
        SSML,

        [Description("application/vnd.sailingtracker.track")]
        ST,

        [Description("application/vnd.sun.xml.calc.template")]
        STC,

        [Description("application/vnd.sun.xml.draw.template")]
        STD,

        [Description("application/vnd.wt.stf")]
        STF,

        [Description("application/vnd.sun.xml.impress.template")]
        STI,

        [Description("application/hyperstudio")]
        STK,

        [Description("application/vnd.ms-pki.stl")]
        STL,

        [Description("application/vnd.pg.format")]
        STR,

        [Description("application/vnd.sun.xml.writer.template")]
        STW,

        [Description("text/vnd.dvb.subtitle")]
        SUB,

        [Description("application/vnd.sus-calendar")]
        SUS,

        [Description("application/vnd.sus-calendar")]
        SUSP,

        [Description("application/x-sv4cpio")]
        SV4CPIO,

        [Description("application/x-sv4crc")]
        SV4CRC,

        [Description("application/vnd.dvb.service")]
        SVC,

        [Description("application/vnd.svd")]
        SVD,

        [Description("image/svg+xml")]
        SVG,

        [Description("image/svg+xml")]
        SVGZ,

        [Description("application/x-director")]
        SWA,

        [Description("application/x-shockwave-flash")]
        SWF,

        [Description("application/vnd.aristanetworks.swi")]
        SWI,

        [Description("application/vnd.sun.xml.calc")]
        SXC,

        [Description("application/vnd.sun.xml.draw")]
        SXD,

        [Description("application/vnd.sun.xml.writer.global")]
        SXG,

        [Description("application/vnd.sun.xml.impress")]
        SXI,

        [Description("application/vnd.sun.xml.math")]
        SXM,

        [Description("application/vnd.sun.xml.writer")]
        SXW,

        [Description("application/x-troff")]
        T,

        [Description("application/x-t3vm-image")]
        T3,

        [Description("application/vnd.mynfc")]
        TAGLET,

        [Description("application/vnd.tao.intent-module-archive")]
        TAO,

        [Description("application/x-tar")]
        TAR,

        [Description("application/vnd.3gpp2.tcap")]
        TCAP,

        [Description("application/x-tcl")]
        TCL,

        [Description("application/vnd.smart.teacher")]
        TEACHER,

        [Description("application/tei+xml")]
        TEI,

        [Description("application/tei+xml")]
        TEICORPUS,

        [Description("application/x-tex")]
        TEX,

        [Description("application/x-texinfo")]
        TEXI,

        [Description("application/x-texinfo")]
        TEXINFO,

        [Description("text/plain")]
        TEXT,

        [Description("application/thraud+xml")]
        TFI,

        [Description("application/x-tex-tfm")]
        TFM,

        [Description("image/x-tga")]
        TGA,

        [Description("application/vnd.ms-officetheme")]
        THMX,

        [Description("image/tiff")]
        TIF,

        [Description("image/tiff")]
        TIFF,

        [Description("application/vnd.tmobile-livetv")]
        TMO,

        [Description("application/x-bittorrent")]
        TORRENT,

        [Description("application/vnd.groove-tool-template")]
        TPL,

        [Description("application/vnd.trid.tpt")]
        TPT,

        [Description("application/x-troff")]
        TR,

        [Description("application/vnd.trueapp")]
        TRA,

        [Description("application/x-msterminal")]
        TRM,

        [Description("application/timestamped-data")]
        TSD,

        [Description("text/tab-separated-values")]
        TSV,

        [Description("application/x-font-ttf")]
        TTC,

        [Description("application/x-font-ttf")]
        TTF,

        [Description("text/turtle")]
        TTL,

        [Description("application/vnd.simtech-mindmapper")]
        TWD,

        [Description("application/vnd.simtech-mindmapper")]
        TWDS,

        [Description("application/vnd.genomatix.tuxedo")]
        TXD,

        [Description("application/vnd.mobius.txf")]
        TXF,

        [Description("text/plain")]
        TXT,

        [Description("application/x-authorware-bin")]
        U32,

        [Description("application/x-debian-package")]
        UDEB,

        [Description("application/vnd.ufdl")]
        UFD,

        [Description("application/vnd.ufdl")]
        UFDL,

        [Description("application/x-glulx")]
        ULX,

        [Description("application/vnd.umajin")]
        UMJ,

        [Description("application/vnd.unity")]
        UNITYWEB,

        [Description("application/vnd.uoml+xml")]
        UOML,

        [Description("text/uri-list")]
        URI,

        [Description("text/uri-list")]
        URIS,

        [Description("text/uri-list")]
        URLS,

        [Description("application/x-ustar")]
        USTAR,

        [Description("application/vnd.uiq.theme")]
        UTZ,

        [Description("text/x-uuencode")]
        UU,

        [Description("audio/vnd.dece.audio")]
        UVA,

        [Description("application/vnd.dece.data")]
        UVD,

        [Description("application/vnd.dece.data")]
        UVF,

        [Description("image/vnd.dece.graphic")]
        UVG,

        [Description("video/vnd.dece.hd")]
        UVH,

        [Description("image/vnd.dece.graphic")]
        UVI,

        [Description("video/vnd.dece.mobile")]
        UVM,

        [Description("video/vnd.dece.pd")]
        UVP,

        [Description("video/vnd.dece.sd")]
        UVS,

        [Description("application/vnd.dece.ttml+xml")]
        UVT,

        [Description("video/vnd.uvvu.mp4")]
        UVU,

        [Description("video/vnd.dece.video")]
        UVV,

        [Description("audio/vnd.dece.audio")]
        UVVA,

        [Description("application/vnd.dece.data")]
        UVVD,

        [Description("application/vnd.dece.data")]
        UVVF,

        [Description("image/vnd.dece.graphic")]
        UVVG,

        [Description("video/vnd.dece.hd")]
        UVVH,

        [Description("image/vnd.dece.graphic")]
        UVVI,

        [Description("video/vnd.dece.mobile")]
        UVVM,

        [Description("video/vnd.dece.pd")]
        UVVP,

        [Description("video/vnd.dece.sd")]
        UVVS,

        [Description("application/vnd.dece.ttml+xml")]
        UVVT,

        [Description("video/vnd.uvvu.mp4")]
        UVVU,

        [Description("video/vnd.dece.video")]
        UVVV,

        [Description("application/vnd.dece.unspecified")]
        UVVX,

        [Description("application/vnd.dece.zip")]
        UVVZ,

        [Description("application/vnd.dece.unspecified")]
        UVX,

        [Description("application/vnd.dece.zip")]
        UVZ,

        [Description("text/vcard")]
        VCARD,

        [Description("application/x-cdlink")]
        VCD,

        [Description("text/x-vcard")]
        VCF,

        [Description("application/vnd.groove-vcard")]
        VCG,

        [Description("text/x-vcalendar")]
        VCS,

        [Description("application/vnd.vcx")]
        VCX,

        [Description("application/vnd.visionary")]
        VIS,

        [Description("video/vnd.vivo")]
        VIV,

        [Description("video/x-ms-vob")]
        VOB,

        [Description("application/vnd.stardivision.writer")]
        VOR,

        [Description("application/x-authorware-bin")]
        VOX,

        [Description("model/vrml")]
        VRML,

        [Description("application/vnd.visio")]
        VSD,

        [Description("application/vnd.vsf")]
        VSF,

        [Description("application/vnd.visio")]
        VSS,

        [Description("application/vnd.visio")]
        VST,

        [Description("application/vnd.visio")]
        VSW,

        [Description("model/vnd.vtu")]
        VTU,

        [Description("application/voicexml+xml")]
        VXML,

        [Description("application/x-director")]
        W3D,

        [Description("application/x-doom")]
        WAD,

        [Description("audio/x-wav")]
        WAV,

        [Description("audio/x-ms-wax")]
        WAX,

        [Description("image/vnd.wap.wbmp")]
        WBMP,

        [Description("application/vnd.wap.wbxml")]
        WBMXL,

        [Description("application/vnd.criticaltools.wbs+xml")]
        WBS,

        [Description("application/vnd.wap.wbxml")]
        WBXML,

        [Description("application/vnd.ms-works")]
        WCM,

        [Description("application/vnd.ms-works")]
        WDB,

        [Description("image/vnd.ms-photo")]
        WDP,

        [Description("audio/webm")]
        WEBA,

        [Description("video/webm")]
        WEBM,

        [Description("image/webp")]
        WEBP,

        [Description("application/vnd.pmi.widget")]
        WG,

        [Description("application/widget")]
        WGT,

        [Description("application/vnd.ms-works")]
        WKS,

        [Description("video/x-ms-wm")]
        WM,

        [Description("audio/x-ms-wma")]
        WMA,

        [Description("application/x-ms-wmd")]
        WMD,

        [Description("application/x-msmetafile")]
        WMF,

        [Description("text/vnd.wap.wml")]
        WML,

        [Description("application/vnd.wap.wmlc")]
        WMLC,

        [Description("text/vnd.wap.wmlscript")]
        WMLS,

        [Description("application/vnd.wap.wmlscriptc")]
        WMLSC,

        [Description("video/x-ms-wmv")]
        WMV,

        [Description("video/x-ms-wmx")]
        WMX,

        [Description("application/x-msmetafile")]
        WMZ,

        [Description("application/font-woff")]
        WOFF,

        [Description("application/vnd.wordperfect")]
        WPD,

        [Description("application/vnd.ms-wpl")]
        WPL,

        [Description("application/vnd.ms-works")]
        WPS,

        [Description("application/vnd.wqd")]
        WQD,

        [Description("application/x-mswrite")]
        WRI,

        [Description("model/vrml")]
        WRL,

        [Description("application/wsdl+xml")]
        WSDL,

        [Description("application/wspolicy+xml")]
        WSPOLICY,

        [Description("application/vnd.webturbo")]
        WTB,

        [Description("video/x-ms-wvx")]
        WVX,

        [Description("application/x-authorware-bin")]
        X32,

        [Description("model/x3d+xml")]
        X3D,

        [Description("model/x3d+binary")]
        X3DB,

        [Description("model/x3d+binary")]
        X3DBZ,

        [Description("model/x3d+vrml")]
        X3DV,

        [Description("model/x3d+vrml")]
        X3DVZ,

        [Description("model/x3d+xml")]
        X3DZ,

        [Description("application/xaml+xml")]
        XAML,

        [Description("application/x-silverlight-app")]
        XAP,

        [Description("application/vnd.xara")]
        XAR,

        [Description("application/x-ms-xbap")]
        XBAP,

        [Description("application/vnd.fujixerox.docuworks.binder")]
        XBD,

        [Description("image/x-xbitmap")]
        XBM,

        [Description("application/xcap-diff+xml")]
        XDF,

        [Description("application/vnd.syncml.dm+xml")]
        XDM,

        [Description("application/vnd.adobe.xdp+xml")]
        XDP,

        [Description("application/dssc+xml")]
        XDSSC,

        [Description("application/vnd.fujixerox.docuworks")]
        XDW,

        [Description("application/xenc+xml")]
        XENC,

        [Description("application/patch-ops-error+xml")]
        XER,

        [Description("application/vnd.adobe.xfdf")]
        XFDF,

        [Description("application/vnd.xfdl")]
        XFDL,

        [Description("application/xhtml+xml")]
        XHT,

        [Description("application/xhtml+xml")]
        XHTML,

        [Description("application/xv+xml")]
        XHVML,

        [Description("image/vnd.xiff")]
        XIF,

        [Description("application/vnd.ms-excel")]
        XLA,

        [Description("application/vnd.ms-excel.addin.macroenabled.12")]
        XLAM,

        [Description("application/vnd.ms-excel")]
        XLC,

        [Description("application/x-xliff+xml")]
        XLF,

        [Description("application/vnd.ms-excel")]
        XLM,

        [Description("application/vnd.ms-excel")]
        XLS,

        [Description("application/vnd.ms-excel.sheet.binary.macroenabled.12")]
        XLSB,

        [Description("application/vnd.ms-excel.sheet.macroenabled.12")]
        XLSM,

        [Description("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        XLSX,

        [Description("application/vnd.ms-excel")]
        XLT,

        [Description("application/vnd.ms-excel.template.macroenabled.12")]
        XLTM,

        [Description("application/vnd.openxmlformats-officedocument.spreadsheetml.template")]
        XLTX,

        [Description("application/vnd.ms-excel")]
        XLW,

        [Description("audio/xm")]
        XM,

        [Description("application/xml")]
        XML,

        [Description("application/vnd.olpc-sugar")]
        XO,

        [Description("application/xop+xml")]
        XOP,

        [Description("application/x-xpinstall")]
        XPI,

        [Description("application/xproc+xml")]
        XPL,

        [Description("image/x-xpixmap")]
        XPM,

        [Description("application/vnd.is-xpr")]
        XPR,

        [Description("application/vnd.ms-xpsdocument")]
        XPS,

        [Description("application/vnd.intercon.formnet")]
        XPW,

        [Description("application/vnd.intercon.formnet")]
        XPX,

        [Description("application/xml")]
        XSL,

        [Description("application/xslt+xml")]
        XSLT,

        [Description("application/vnd.syncml+xml")]
        XSM,

        [Description("application/xspf+xml")]
        XSPF,

        [Description("application/vnd.mozilla.xul+xml")]
        XUL,

        [Description("application/xv+xml")]
        XVM,

        [Description("application/xv+xml")]
        XVML,

        [Description("image/x-xwindowdump")]
        XWD,

        [Description("chemical/x-xyz")]
        XYZ,

        [Description("application/x-xz")]
        XZ,

        [Description("application/yang")]
        YANG,

        [Description("application/yin+xml")]
        YIN,

        [Description("application/x-zmachine")]
        Z1,

        [Description("application/x-zmachine")]
        Z2,

        [Description("application/x-zmachine")]
        Z3,

        [Description("application/x-zmachine")]
        Z4,

        [Description("application/x-zmachine")]
        Z5,

        [Description("application/x-zmachine")]
        Z6,

        [Description("application/x-zmachine")]
        Z7,

        [Description("application/x-zmachine")]
        Z8,

        [Description("application/vnd.zzazz.deck+xml")]
        ZAZ,

        [Description("application/zip")]
        ZIP,

        [Description("application/vnd.zul")]
        ZIR,

        [Description("application/vnd.zul")]
        ZIRZ,

        [Description("application/vnd.handheld-entertainment+xml")]
        ZMM,

        [Description("application/octet-stream")]
        DEFAULT
    }
}