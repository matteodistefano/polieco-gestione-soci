Namespace DAL
    Public Module Enums

        Public AttrezzatureConMisure() As String = New String() {"004", "0005"}

        Public Structure StatoSocio
            Public Const ATTIVO = "0001"
            Public Const NUOVO = "0018"
            Public Const USCITO = "0019"
        End Structure

        Public Structure InfoStatoSocio
            Public Const NOINFO = "0000"
            Public Const ISCNC_NO_ATT_PRINC = "0001"
            Public Const ISCNC_NO_PROD = "0002"
            Public Const ISCNC_NO_BILANCIO = "0003"
            Public Const ISCNC_NO_CCIAA = "0004"
            Public Const OK = "0005"

            Public Const USCITO = "0020"

            Public Const NOREG_DIC = "0021"
            Public Const NOREG_PAG = "0022"
            Public Const NOREG_DIC_PAG = "0023"
            Public Const PROSSIMA_USCITA = "0024"

        End Structure

        Public Structure CodTipoSede
            Public Const PRINCIPALE = "PRI"
            Public Const SECONDARIA = "SEC"
        End Structure

        Public Structure CodTipoAttivita
            Public Const PRINCIPALE = "PRI"
            Public Const SECONDARIA = "SEC"
        End Structure

        Public Structure Ruolo
            Public Const AMMINISTRATORE = "admin"
            Public Const DIREZIONE = "direzione"
            Public Const CONTABILITA = "contabilita"
            Public Const SEGRETERIA = "user"
            Public Const SEMPLICE = "smp"
            Public Const REPORT_QUOTE = "list.quote"
        End Structure

        Public Structure StatoDocumento
            Public Const NO = "NO"
            Public Const OK = "OK"
            Public Const [PARTIAL] = "PARTIAL"
            Public Const FORCED = "FORCED"
        End Structure

        Public Structure TipoRiunione
            Public Const ASSEMBLEA = "ASSEMBLY"
            Public Const CDA = "CDA"
        End Structure

        Public Structure MotivoPassaggio
            Public Const NUOVO = "NUOVO"
            Public Const RAGIONE_SOCIALE = "RAGSOC"
            Public Const USCITA = "USCITA"
        End Structure

        Public Structure TipoEvento
            Public Const ADVICE_SENT_M = "ADVICE_SENT_M"
            Public Const AGENCY_ADVICE_TO_M = "AGENCY_ADVICE_TO_M"
            Public Const AGENCY_RESPONSE_M = "AGENCY_RESPONSE_M"
            Public Const ASSIGNMENT_NEW_TO_SUB_M = "ASSIGNMENT_NEW_TO_SUB_M"
            Public Const ASSIGNMENT_RECYCLING_M = "ASSIGNMENT_RECYCLING_M"
            Public Const ASSIGNMENT_TO_SUBJECT_M = "ASSIGNMENT_TO_SUBJECT_M"
            Public Const BOARD_OF_DIR_PASSAGE = "BOARD_OF_DIR_PASSAGE"
            Public Const CATEGORY_CHANGE = "CATEGORY_CHANGE"
            Public Const CERTIFICATE_DECLARATION = "CERTIFICATE_DECLARATION"
            Public Const COMPANY_ACTIVITY_IN = "COMPANY_ACTIVITY_IN"
            Public Const COMPANY_IN = "COMPANY_IN"
            Public Const COMPANY_NAME_CHANGE = "COMPANY_NAME_CHANGE"
            Public Const COMPANY_NAME_CHANGE_PASSED = "COMPANY_NAME_CHANGE_PASSED"
            Public Const EXAM_PROCEDURE_COMM_M = "EXAM_PROCEDURE_COMM_M"
            Public Const [EXIT] = "EXIT"
            Public Const EXIT_CDA = "EXIT_CDA"
            Public Const EXIT_FROM_POLIECO_M = "EXIT_FROM_POLIECO_M"
            Public Const EXIT_PLENUM = "EXIT_PLENUM"
            Public Const EXTRA_TRANS_COMM_M = "EXTRA_TRANS_COMM_M"
            Public Const GENERIC_EVENT_M = "GENERIC_EVENT_M"
            Public Const INSPECTION_NECESSARY_M = "INSPECTION_NECESSARY_M"
            Public Const INSPECTION_REQUEST_M = "INSPECTION_REQUEST_M"
            Public Const INSPECTION_RESPONSE_M = "INSPECTION_RESPONSE_M"
            Public Const LETTER_GENERATION = "LETTER_GENERATION"
            Public Const PAYMENT_DONE_TO_SUB_M = "PAYMENT_DONE_TO_SUB_M"
            Public Const PLENUM_PASSAGE = "PLENUM_PASSAGE"
            Public Const RECYCLING_OFFER_M = "RECYCLING_OFFER_M"
            Public Const RECYCLING_REQUEST_M = "RECYCLING_REQUEST_M"
            Public Const SANATORIUM_GRANTED_M = "SANATORIUM_GRANTED_M"
            Public Const SANCTION_INVOICE_SENT_M = "SANCTION_INVOICE_SENT_M"
            Public Const RICHIESTA_DICHIARAZIONE_M = "RICHIESTA_DICHIARAZIONE_M"
            Public Const DA_SANARE_M = "DA_SANARE_M"
            Public Const REMINDER_M = "REMINDER_M"
            Public Const RECESSO_ECOPLT_M = "RECESSO_ECOPLT_M"
            Public Const AUTH_M = "AUTH_M"
        End Structure

        Public Structure TipoSocio
            Public Const ARC_STO = "ARC_STO"
            Public Const ASS_CAT = "ASS_CAT"
            Public Const SOC_AGR = "SOC_AGR"
            Public Const SOC_ORD = "SOC_ORD"
        End Structure

        Public Structure RuoliContatto
            Public Const NOD_DEFINITO = "role0"
            Public Const TITOLARE = "role1"
            Public Const LEGALE_RAPPRESENTANTE = "role2"
            Public Const RESP_RAPPORTI_POLIECO = "role3"
            Public Const LEGALE = "role4"
            Public Const RESPONSABILE_AMMINISTRATIVO = "role5"
            Public Const RESPONSABILE_ESECUTIVO = "role6"
            Public Const AMMINISTRAZIONE = "role7"
            Public Const AMMINISTRATORE_DELEGATO = "role8"
            Public Const AMMINISTRATORE_UNICO = "role9"
        End Structure

        Public Structure TipiMateriale
            Public Const ARROTONDAMENTO = "ARROTONDAMENTO"
            Public Const CONTRIBUTO = "CONTRIBUTO"
            Public Const MATERIAPRIMA = "MATERIAPRIMA"
            Public Const PRODOTTI = "PRODOTTI"
            Public Const RIFIUTI = "RIFIUTI"
        End Structure

        Public Structure TipiIncasso
            Public Const VERSAMENTO = "VERSAMENTO"
            Public Const RATA = "RATA"
            Public Const RATAPAGATA = "RATAPAGATA"
        End Structure

        Public Structure StatoEvento
            Public Const INDEFINITO = ""
            Public Const OPEN = "OPEN"
            Public Const DONE = "DONE"
        End Structure

        Public Structure MotivoLibroSoci
            Public Const NUOVO = "NUOVO"
            Public Const NUOVO_CRS = "NUOVO_CRS"
            Public Const USCITA = "USCITA"
            Public Const USCITA_CRS = "USCITA_CRS"
        End Structure

        Public Structure RuoloAziendaAllegato
            Public Const FORNITORE = "F"
            Public Const RICEVITORE = "R"
        End Structure


        Public Structure StatoDOL
            Public Const INSERITA = "INS"
            Public Const VALIDATA = "VAL"
            Public Const ASSOCIATA = "ASS"
            Public Const ANNULLATA = "ANN"
        End Structure

        Public Enum StateCompleteEnum
            UNCOMPLETE
            [PARTIAL]
            COMPLETE
        End Enum
        Public Structure UNITA_MISURA
            Public Const KG = "Kg"
            Public Const TONN = "Tn"
            Public Const EURO = "Euro"
        End Structure


    End Module
End Namespace
