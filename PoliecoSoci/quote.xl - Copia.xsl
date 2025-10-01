<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
xmlns:x="urn:schemas-microsoft-com:office:excel">

  
<xsl:output method="html" />
<xsl:template match="report">

<html xmlns:o="urn:schemas-microsoft-com:office:office"  
             xmlns:x="urn:schemas-microsoft-com:office:excel" 
             xmlns="http://www.w3.org/TR/REC-html40">

<head>
<meta http-equiv="Content-Type" content="text/html; charset=windows-1252"/>
<meta name="ProgId" content="Excel.Sheet"/>
<meta name="Generator" content="Microsoft Excel 11"/>
<link rel="File-List" href="Cartel1_file/filelist.xml"/>
<link rel="Edit-Time-Data" href="Cartel1_file/editdata.mso"/>
<link rel="OLE-Object-Data" href="Cartel1_file/oledata.mso"/>

<style type="text/css">
.base {
    mso-number-format:General;
	text-align:general;
	vertical-align:bottom;
	white-space:nowrap;
	mso-rotate:0;
	mso-background-source:auto;
	mso-pattern:auto;
	color:windowtext;
	font-size:10.0pt;
	font-weight:400;
	font-style:normal;
	text-decoration:none;
	font-family:Arial;
	mso-generic-font-family:auto;
	mso-font-charset:0;
	border:none;
	mso-protection:locked visible;
	mso-style-name:Normale;
	mso-style-id:0;
}

.nuumber {
    mso-number-format:"_-* \#\,\#\#0\.00_-\;\\-* \#\,\#\#0\.00_-\;_-* \0022-\0022??_-\;_-\@_-";
	  mso-style-name:Migliaia;
	  mso-style-id:3;
}
.perc {
    mso-number-format:0%;
	mso-style-name:Percentuale;
	mso-style-id:5;
}

td {
    mso-style-parent:base;
	padding:0px;
	mso-ignore:padding;
	color:windowtext;
	font-size:10.0pt;
	font-weight:400;
	font-style:normal;
	text-decoration:none;
	mso-generic-font-family:auto;
	mso-font-charset:0;
	mso-number-format:General;
	text-align:general;
	vertical-align:bottom;
	border:none;
	mso-background-source:auto;
	mso-pattern:auto;
	mso-protection:locked visible;
	white-space:nowrap;
	mso-rotate:0;
}

.tdright {
  mso-style-parent:base;
  text-align:right;
}

.tdleft {
    mso-style-parent:base;
	text-align:left;
}

.percent {
    mso-style-parent:base;
	mso-number-format:"0\.00000%";
}

.title {
    mso-style-parent:base;
	font-size:9.0pt;
	mso-font-charset:0;
	text-align:center;
	vertical-align:middle;
}

.font9bold {
    color:windowtext;
	font-size:9.0pt;
	font-weight:700;
	font-style:normal;
	text-decoration:none;
	mso-font-charset:0;
}

.font9 {
    mso-style-parent:base;
    color:windowtext;
	font-size:9.0pt;
	font-style:normal;
	text-decoration:none;
	mso-font-charset:0;
	white-space:normal;
}

.italic9 {
    mso-style-parent:base;
	font-size:9.0pt;
	font-style:italic;
	mso-font-charset:0;
	text-align:center;
	vertical-align:middle;
}

.titlecat {
    mso-style-parent:base;
	font-size:9.0pt;
	font-weight:700;
	font-style:italic;
	mso-font-charset:0;
	text-align:left;
	vertical-align:middle;
}

.headertab {
    mso-style-parent:base;
	color:black;
	mso-generic-font-family:auto;
	mso-font-charset:0;
	text-align:center;
	border:.5pt solid windowtext;
	background:silver;
	mso-pattern:black none;
}

.tabperc {
    mso-style-parent:base;
	font-size:9.0pt;
	font-weight:700;
	mso-font-charset:0;
	mso-number-format:"0\.00000%";
	text-align:center;
	vertical-align:middle;
	border:.5pt solid windowtext;
	white-space:normal;
}

.tabpercblu {
    mso-style-parent:base;
	color:#3366FF;
	font-size:9.0pt;
	font-weight:700;
	mso-font-charset:0;
	mso-number-format:"0\.0000%";
	text-align:center;
	vertical-align:middle;
	border:.5pt solid windowtext;
	white-space:normal;
}

.tabpercred {
    mso-style-parent:base;
	color:red;
	font-size:9.0pt;
	font-weight:700;
	mso-font-charset:0;
	mso-number-format:"0\.0000%";
	text-align:center;
	vertical-align:middle;
	border:.5pt solid windowtext;
	white-space:normal;
}

.tabpercgreen {
    mso-style-parent:base;
	color:#339966;
	font-size:9.0pt;
	font-weight:700;
	mso-font-charset:0;
	mso-number-format:"0\.0000%";
	text-align:center;
	vertical-align:middle;
	border:.5pt solid windowtext;
	white-space:normal;
}

.bold8red {
    mso-number-format:"_-* \#\,\#\#0_-\;\\-* \#\,\#\#0_-\;_-* \0022-\0022_-\;_-\@_-";
	mso-style-name:"Migliaia \[0\]";
	color:red;
	font-size:8.0pt;
	font-weight:700;
	mso-font-charset:0;
	mso-number-format:0;
	text-align:center;
	vertical-align:middle;
	white-space:normal;
}

.bold8 {
    mso-style-parent:base;
	font-size:8.0pt;
	font-weight:700;
	mso-font-charset:0;
	white-space:normal;
}

.contentNormal {
    mso-style-parent:base;
	color:black;
	mso-font-charset:0;
	border:.5pt solid windowtext;
	mso-background-source:auto;
	mso-pattern:auto;
	white-space:normal;
}

.contentNormalNoBorder {
    mso-style-parent:base;
	color:black;
	mso-font-charset:0;
	mso-background-source:auto;
	mso-pattern:auto;
	white-space:normal;
}
.contentBoldNoBorder {
    mso-style-parent:base;
	color:black;
	font-weight:700;	
	mso-font-charset:0;
	mso-background-source:auto;
	mso-pattern:auto;
	white-space:normal;
}

.numcontentNormal {
    mso-style-parent:base;
	color:black;
	mso-font-charset:0;
	border:.5pt solid windowtext;
	mso-background-source:auto;
	mso-pattern:auto;
	white-space:normal;
    mso-number-format:"\#\,\#\#0\.0000";	
}

.numcontentNoborder9 {
    mso-style-parent:number;
	font-size:9.0pt;
	mso-font-charset:0;
	mso-number-format:0;
	border-top:none;
	border-right:none;
	border-bottom:none;
	border-left:none;
}

.total {
    mso-style-parent:style0;
	color:black;
	font-weight:700;
	mso-font-charset:0;
	mso-background-source:auto;
	mso-pattern:auto;
	white-space:normal;
}

.percBlack {
    mso-style-parent:perc;
	font-size:9.0pt;
	mso-font-charset:0;
	mso-number-format:"0\.00000%";
	text-align:center;
	vertical-align:middle;
	border:.5pt solid windowtext;
}

.percBlu {
    mso-style-parent:perc;
    color:#3366FF;
	font-size:9.0pt;
	font-weight:700;	
	mso-font-charset:0;
	mso-number-format:"0\.00000%";
	text-align:center;
	vertical-align:middle;
	border:.5pt solid windowtext;
}

.percRed {
    mso-style-parent:perc;
    color:red;
	font-size:9.0pt;
	font-weight:700;	
	mso-font-charset:0;
	mso-number-format:"0\.00000%";
	text-align:center;
	vertical-align:middle;
	border:.5pt solid windowtext;
}

.percGreen {
    mso-style-parent:perc;
    color:#339966;
	font-size:9.0pt;
	font-weight:700;	
	mso-font-charset:0;
	mso-number-format:"0\.00000%";
	text-align:center;
	vertical-align:middle;
	border:.5pt solid windowtext;
}

.totalNumber {
    mso-style-parent:base;
	font-weight:700;
	mso-font-charset:0;
	mso-number-format:Standard;
	text-align:right;
}

.totalPercBlack {
    mso-style-parent:base;
	font-weight:700;
	mso-number-format:"0\.00000%";
}

.totalPercBlu {
    mso-style-parent:base;
	font-weight:700;
	mso-number-format:"0\.00000%";
	color:#3366FF;
}

.totalPercRed {
    mso-style-parent:base;
	font-weight:700;
	mso-number-format:"0\.00000%";
	color:red;
}

.totalPercGreen {
    mso-style-parent:base;
	font-weight:700;
	mso-number-format:"0\.00000%";
	color:#339966;
}

.noBorderBluPerc {
    mso-style-parent:perc;
	color:blue;
	font-weight:700;
	mso-font-charset:0;
	mso-number-format:Percent;
}

.noBorderGreenPerc {
    mso-style-parent:perc;
	color:green;
	font-weight:700;
	mso-font-charset:0;
	mso-number-format:Percent;
}


</style>
</head>
<body>
  <table border="0" cellpadding="0" cellspacing="0">   
    <tr>
      <td width="17"/>
      <td width="354"/>
      <td width="57"/>
      <td class="tdright" width="82"/>
      <td width="49"/>
      <td class="percent" width="101"/>
      <td class="percent" width="100"/>
      <td class="tdleft" width="100"/>
      <td class="tdleft" width="100"/>
      <td class="tdleft" width="100"/>
      <td width="436"/>
      <td width="63"/>
      <td width="84"/>
      <td width="83"/>
      <td width="436"/>
      <td width="64"/>
      <td width="70"/>
      <td width="70"/>
    </tr>
    
    <tr height="17">
      <td> </td>
      <td colspan="3" class="title">CONSORZIO PER IL RICICLAGGIO DEI RIFIUTI DI BENI IN POLIETILENE</td>
    </tr>
    
    <tr height="17">
      <td> </td>
      <td colspan="3" class="title">RIPARTIZIONE QUOTE CONSORTILI <font class="font9bold">anno <xsl:value-of select="/report/parametro[@nome='Anno']/@valore"/></font></td>
    </tr>
    
    <tr height="17">
      <td> </td>
    </tr>
    
    <tr height="17">
      <td> </td>
      <td colspan="3" class="italic9">(I quantitativi dichiarati sono espressi in Tonnellate)</td>
    </tr>

    <tr height="25">
      <td>&#160;</td>
    </tr>
    
    <!-- *********************************
                CATEGORY SECTION
         ********************************* -->
    <!--  row variable -->
    <xsl:variable name="headerrow">6</xsl:variable>
    <xsl:variable name="headercatgoryrow">3</xsl:variable>
    <xsl:variable name="bottomcatgoryrow">3</xsl:variable>
    <xsl:variable name="categoryArow">
      <xsl:value-of select="count(//report/analisi[@CatQuota='A'])"/>
    </xsl:variable>
    <xsl:variable name="categoryBrow">
		  <xsl:value-of select="count(//report/analisi[@CatQuota='B'])"/>
	  </xsl:variable>
	  <xsl:variable name="categoryCrow">
		  <xsl:value-of select="count(//report/analisi[@CatQuota='C'])"/>
	  </xsl:variable>
	  <xsl:variable name="categoryDrow">
		  <xsl:value-of select="count(//report/analisi[@CatQuota='D'])"/>
	  </xsl:variable>
	  <xsl:variable name="categoryErow">
		  <xsl:value-of select="count(//report/analisi[@CatQuota='E'])"/>
	  </xsl:variable>

      
    <xsl:for-each select="/report/parametro[@nome='Categoria']">
       
       <xsl:variable name="category" select="./@valore"/>
            
      
       <tr height="17">
         <td> </td>
         <td class="titlecat"><u><em>CAT. <xsl:value-of select="$category"/></em></u></td>
       </tr>
       <tr height="17">
         <td> </td>
       </tr>
       
       <!--  HEADER -->
       <tr height="51">
         <td class="headertab"> </td>
         <td class="headertab">Denominazione</td>
         <td class="headertab">Altre cat</td>
         <td class="headertab">peso</td>
         <td class="font9">Adempienze <strong>0</strong> o <strong>1</strong></td>
         <td class="tabperc">quota in categoria</td>
         <td class="tabperc">quota in consorzio</td>
         <td class="tabpercblu">quota ademp.</td>
         <td class="tabpercred">quota morosi</td>
         <td class="tabpercgreen">quorum su ademp.</td>
         <td class="font9">Denominazione</td>
         <td class="bold8red">presente 0/1</td>
         <td class="bold8">quota ademp.</td>
         <td class="bold8">quorum su ademp.</td>
         <td class="font9">Denominazione</td>
         <td class="bold8red">voto: F/C/A</td>
        </tr>
               
        <xsl:call-template name="contentcategory">
            <xsl:with-param name="category" select="$category"/>
            <xsl:with-param name="headerrow" select="$headerrow"/>
            <xsl:with-param name="headercatgoryrow" select="$headercatgoryrow"/>
            <xsl:with-param name="bottomcatgoryrow" select="$bottomcatgoryrow"/>
            <xsl:with-param name="categoryArow" select="$categoryArow"/>            
            <xsl:with-param name="categoryBrow" select="$categoryBrow"/>
            <xsl:with-param name="categoryCrow" select="$categoryCrow"/>
            <xsl:with-param name="categoryDrow" select="$categoryDrow"/>
            <xsl:with-param name="categoryErow" select="$categoryErow"/>
        </xsl:call-template>
        
        <tr height="17">
          <td> </td>
        </tr>
        <tr height="17">
          <td> </td>
        </tr>
                           
    </xsl:for-each>
   
    
  </table>

</body>

</html>

</xsl:template>

<!-- ******************************************
           TEMPLATE CONTENT CATEGORY 
     ******************************************-->
<xsl:template name="contentcategory" xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet" xmlns="urn:schemas-microsoft-com:office:spreadsheet">
   <xsl:param name="category"/>
   <xsl:param name="headerrow"/>
   <xsl:param name="headercatgoryrow"/>
   <xsl:param name="bottomcatgoryrow"/>
   <xsl:param name="categoryArow"/>            
   <xsl:param name="categoryBrow"/>
   <xsl:param name="categoryCrow"/>
   <xsl:param name="categoryDrow"/>
   <xsl:param name="categoryErow"/>
   
  <xsl:variable name="catAspan">
      <xsl:value-of select="$headercatgoryrow + $bottomcatgoryrow + $categoryArow "/>
  </xsl:variable>

  <xsl:variable name="catBspan">
      <xsl:value-of select="$headercatgoryrow + $bottomcatgoryrow + $categoryBrow"/>
  </xsl:variable>
  
  <xsl:variable name="catCspan">
      <xsl:value-of select="$headercatgoryrow + $bottomcatgoryrow + $categoryCrow"/>
  </xsl:variable>
  
  <xsl:variable name="catDspan">
      <xsl:value-of select="$headercatgoryrow + $bottomcatgoryrow + $categoryDrow"/>
  </xsl:variable>

  <xsl:variable name="catEspan">
      <xsl:value-of select="$headercatgoryrow + $bottomcatgoryrow + $categoryErow"/>
  </xsl:variable>

  <!-- row to startsum -->
  <xsl:variable name="startsum">
    <xsl:if test="$category = 'A'"><xsl:value-of select="($headerrow + $headercatgoryrow + 1)"/></xsl:if>
    <xsl:if test="$category = 'B'"><xsl:value-of select="($headerrow + $headercatgoryrow + 1 + $catAspan)"/></xsl:if>
    <xsl:if test="$category = 'C'"><xsl:value-of select="($headerrow + $headercatgoryrow + 1 + $catAspan + $catBspan)"/></xsl:if>
    <xsl:if test="$category = 'D'"><xsl:value-of select="($headerrow + $headercatgoryrow + 1 + $catAspan + $catBspan + $catCspan)"/></xsl:if>
    <xsl:if test="$category = 'E'"><xsl:value-of select="($headerrow + $headercatgoryrow + 1 + $catAspan + $catBspan + $catCspan + $catDspan)"/></xsl:if>
  </xsl:variable>
  
  <!-- row to end sum -->
  <xsl:variable name="endsum">
    <xsl:if test="$category = 'A'"><xsl:value-of select="($headerrow + $headercatgoryrow + $categoryArow)"/></xsl:if>
    <xsl:if test="$category = 'B'"><xsl:value-of select="($headerrow + $headercatgoryrow + $catAspan + $categoryBrow)"/></xsl:if>
    <xsl:if test="$category = 'C'"><xsl:value-of select="($headerrow + $headercatgoryrow + $catAspan + $catBspan + $categoryCrow)"/></xsl:if>
    <xsl:if test="$category = 'D'"><xsl:value-of select="($headerrow + $headercatgoryrow + $catAspan + $catBspan + $catCspan + $categoryDrow)"/></xsl:if>
    <xsl:if test="$category = 'E'"><xsl:value-of select="($headerrow + $headercatgoryrow + $catAspan + $catBspan + $catCspan + $catDspan + $categoryErow)"/></xsl:if>
  </xsl:variable>
  
  
<!--  DEBUG SECTION -->
 <!--<tr>
   <td><xsl:value-of select="$category"/></td>
   <td><xsl:value-of select="$categoryArow"/></td>
   <td><xsl:value-of select="$categoryBrow"/></td>
   <td><xsl:value-of select="$categoryCrow"/></td>
   <td><xsl:value-of select="$categoryDrow"/></td>
   <td><xsl:value-of select="$categoryErow"/></td>   
   <td><xsl:value-of select="$catAspan"/></td>
   <td><xsl:value-of select="$catBspan"/></td>
   <td><xsl:value-of select="$catCspan"/></td>
   <td><xsl:value-of select="$catDspan"/></td>
   <td><xsl:value-of select="$catEspan"/></td>   
   <td><xsl:value-of select="$startsum"/></td>
   <td><xsl:value-of select="$endsum"/></td>
 </tr>-->
  
    
    
      <xsl:for-each select="/report/analisi[@CatQuota=$category]">
         <!--  CALCULATE POSITION ON EXCEL -->
         <xsl:variable name="count">
           <xsl:if test="$category = 'A'">        
             <xsl:if test="position() = 1">
               1
             </xsl:if>
             <xsl:if test="position() > 1">
               <xsl:value-of select="count(preceding-sibling::analisi[@CatQuota = 'A']) +1"/>
             </xsl:if>
           </xsl:if>
           
           <xsl:if test="$category = 'B'">
				     <xsl:value-of select="count(preceding-sibling::analisi[@CatQuota = 'B'])+1"/>
			     </xsl:if>
           
			     <xsl:if test="$category = 'C'">
				     <xsl:value-of select="count(preceding-sibling::analisi[@CatQuota = 'C'])+1"/>
			     </xsl:if>
           
           <xsl:if test="$category = 'D'">
				     <xsl:value-of select="count(preceding-sibling::analisi[@CatQuota = 'D'])+1"/>
			     </xsl:if>
           
           <xsl:if test="$category = 'E'">
				     <xsl:value-of select="count(preceding-sibling::analisi[@CatQuota = 'E'])+1"/>
			     </xsl:if>
           
		 </xsl:variable>
     
         <tr height="17">
           <!--  category --> 
           <td class="contentNormal" align="right"><xsl:value-of select="$category"/></td>
       
           <!-- firmname -->
           <td class="contentNormal" align="left">
             <xsl:if test="(./@Cat1 = $category)">
               <strong><xsl:value-of select="./@RagioneSociale"/></strong>
             </xsl:if>
             <xsl:if test="(./@Cat1 != $category)">
               <xsl:value-of select="./@RagioneSociale"/>
             </xsl:if>
           </td>
       
           <!-- activity list -->
           <td class="contentNormal" align="center">
             <xsl:value-of select="./@AltreCat"/>   
	         <!--<xsl:call-template name="activitylist">
                <xsl:with-param name="companykey" select="$companykey"/>
                <xsl:with-param name="category" select="$category"/>                
             </xsl:call-template>-->
           </td>
       
           <!-- weight -->
           <td class="numcontentNormal" align="right" x:num="{./@Peso}">
           </td>
       
           <!-- payment status and declaration status -->
           <td class="numcontentNoborder9" x:num="{./@Adempimento}"></td>
         
           <!-- category quote -->
           <td class="percBlack" x:fmla="if(D{$count - 1 + $startsum}>0,D{$count - 1 + $startsum}/D{$endsum+1},0)"></td>
               
           <!-- Polieco quote -->
           <td class="percBlack" x:fmla="F{$count -1 + $startsum}/ 5"></td>
            
           <!-- company payment and declaration status OK quote -->
           <td class="percBlu" x:fmla="IF(E{$count -1 + $startsum}=1,G{$count -1 + $startsum},0)"></td>
  
           <!-- company payment and declaration status NO quote -->
           <td class="percRed" x:fmla="IF(E{$count -1 + $startsum}=0,G{$count -1 + $startsum},0)"></td>

           <!-- Quote on company == OK for category -->
           <td class="percGreen" x:fmla="IF(E{$count -1 + $startsum}=1,H{$count -1 + $startsum} * 0.20 / H{$endsum+1},0)"></td>
          
           <!-- company name -->
           <xsl:if test="(./@Cat1 = $category)">
             <td class="contentBoldNoBorder" align="left" x:fmla="B{$count -1 + $startsum}" ></td>
           </xsl:if>
           <xsl:if test="(./@Cat1 != $category)">
             <td class="contentNormalNoBorder" align="left" x:fmla="B{$count -1 + $startsum}" ></td>
           </xsl:if>       
           
       
           <td class="contentNormalNoBorder" align="right"></td>
         
           <!-- quote adempienza if company is present -->
           <td class="noBorderBluPerc" x:fmla="IF(L{$count -1 + $startsum}=1,H{$count -1 + $startsum},0)"></td>
        
           <!-- quote no adempienza if company is present -->
           <td class="noBorderGreenPerc" x:fmla="IF(L{$count -1 + $startsum}=1,J{$count -1 + $startsum},0)"></td>
       
           <!-- company name -->
           <xsl:if test="(./@Cat1 = $category)">
             <td class="contentBoldNoBorder" align="left" x:fmla="B{$count -1 + $startsum}" ></td>
           </xsl:if>
           <xsl:if test="(./@Cat1 != $category)">
             <td class="contentNormalNoBorder" align="left" x:fmla="B{$count -1 + $startsum}" ></td>
           </xsl:if>       
 
           <td class="contentNormalNoBorder">1</td>
  
           <!-- quote adempienza if company is present -->
           <td class="noBorderBluPerc" x:fmla="IF(P{$count -1 + $startsum}=1,M{$count -1 + $startsum},0)"></td>
       
           <!-- quote no adempienza if company is present -->
           <td class="noBorderGreenPerc" x:fmla="IF(P{$count -1 + $startsum}=1,N{$count -1 + $startsum},0)"></td>
              
         </tr>
     

     </xsl:for-each>

   
   <!-- section for category E -->
   <!--<xsl:if test="$category = 'B'">
     <xsl:for-each select="//report/section[@id='categoryBlist']/row">
      
       <xsl:variable name="count"><xsl:number/></xsl:variable>

       <tr height="17">
         --><!--  category --><!-- 
         <td class="contentNormal" align="right"><xsl:value-of select="$category"/></td>
       
         --><!-- firmname --><!--
         <td class="contentNormal" align="left">
           <xsl:value-of select="./@sfirmname"/>
         </td>
       
         --><!-- activity list --><!--
         <td class="contentNormal"> </td>
         
         --><!-- weight --><!--
         <td class="numcontentNormal" align="right"></td>
       
         --><!-- payment status and declaration status --><!--
         <xsl:variable name="status">
           <xsl:if test="(./@sdeclarationstatus = 'OK' and ./@spaymentstatus = 'OK')">1</xsl:if>
           <xsl:if test="(./@sdeclarationstatus = 'NO' or ./@spaymentstatus = 'NO')">0</xsl:if>
         </xsl:variable>              
         <td class="numcontentNoborder9" x:num="{$status}"></td>
         
         --><!-- category quote --><!--
         <td class="percBlack" x:fmla="G{$count -1 + $startsum}*5"></td>
               
         --><!-- Polieco quote --><!--
         <td class="percBlack" x:fmla="0.20 / D{$endsum+1}"></td>
 
         --><!-- company payment and declaration status OK quote --><!--
         <td class="percBlu" x:fmla="IF(E{$count -1 + $startsum}=1,G{$count -1 + $startsum},0)"></td>
  
         --><!-- company payment and declaration status NO quote --><!--
         <td class="percRed" x:fmla="IF(E{$count -1 + $startsum}=0,G{$count -1 + $startsum},0)"></td>

         --><!-- Quote on company == OK for category --><!--
         <td class="percGreen" x:fmla="IF(E{$count -1 + $startsum}=1,H{$count -1 + $startsum} * 0.20 / H{$endsum+1},0)"></td>
          
         --><!-- company name --><!--
         <td class="contentNormalNoBorder" align="left">
           <xsl:value-of select="./@sfirmname"/>
         </td>
       
         <td class="contentNormalNoBorder" align="right"></td>
         
         --><!-- quote adempienza if company is present --><!--
         <td class="noBorderBluPerc" x:fmla="IF(L{$count -1 + $startsum}=1,H{$count -1 + $startsum},0)"></td>
        
         --><!-- quote no adempienza if company is present --><!--
         <td class="noBorderGreenPerc" x:fmla="IF(L{$count -1 + $startsum}=1,J{$count -1 + $startsum},0)"></td>
         
         --><!-- company name --><!--
         <td class="contentNormalNoBorder" align="left">
           <xsl:value-of select="./@sfirmname"/>
         </td>

         <td class="contentNormalNoBorder">1</td>
  
         --><!-- quote adempienza if company is present --><!--
         <td class="noBorderBluPerc" x:fmla="IF(P{$count -1 + $startsum}=1,M{$count -1 + $startsum},0)"></td>
       
         --><!-- quote no adempienza if company is present --><!--
         <td class="noBorderGreenPerc" x:fmla="IF(P{$count -1 + $startsum}=1,N{$count -1 + $startsum},0)"></td>
              
       </tr>       

     </xsl:for-each>
   
   </xsl:if>-->


  <tr>
     <td> </td>
     <td class="total" align="left">TOTALE</td>
     <td> </td>
     <xsl:if test="$category != 'B'">
       <td class="totalNumber" align="right" x:fmla="sum(D{$startsum}:D{$endsum})"></td>
     </xsl:if>
     <xsl:if test="$category = 'B'">
       <td class="totalNumber" align="right" x:fmla="counta(B{$startsum}:B{$endsum})"></td>
     </xsl:if>
     <td> </td>
     <td class="totalPercBlack" align="right" x:fmla="sum(F{$startsum}:F{$endsum})"></td>
     <td class="totalPercBlack" align="right" x:fmla="sum(G{$startsum}:G{$endsum})"></td>
     <td class="totalPercBlu" align="right" x:fmla="sum(H{$startsum}:H{$endsum})"></td>
     <td class="totalPercRed" align="right" x:fmla="sum(I{$startsum}:I{$endsum})"></td>
     <td class="totalPercGreen" align="right" x:fmla="sum(J{$startsum}:J{$endsum})"></td>
     <td> </td>
     <td> </td>
     <td class="totalPercBlu" align="right" x:fmla="sum(M{$startsum}:M{$endsum})"></td>
     <td class="totalPercGreen" align="right" x:fmla="sum(N{$startsum}:N{$endsum})"></td>
     <td> </td>
     <td> </td>
     <td class="totalPercBlu" align="right" x:fmla="sum(Q{$startsum}:Q{$endsum})"></td>
     <td class="totalPercGreen" align="right" x:fmla="sum(R{$startsum}:R{$endsum})"></td>     
   </tr>
   
   <!-- se categoria = 'E' allora scrivo anke i totali generali -->
   <xsl:if test="$category = 'E'">
     <!-- row to end sum -->
     <xsl:variable name="totalA">
       <xsl:value-of select="($headerrow + $headercatgoryrow + $categoryArow + 1)"/>
     </xsl:variable>
     <xsl:variable name="totalB">
       <xsl:value-of select="($headerrow + $headercatgoryrow + $catAspan + $categoryBrow + 1)"/>
     </xsl:variable>
     <xsl:variable name="totalC">
       <xsl:value-of select="($headerrow + $headercatgoryrow + $catAspan + $catBspan + $categoryCrow + 1)"/>
     </xsl:variable>
     <xsl:variable name="totalD">
       <xsl:value-of select="($headerrow + $headercatgoryrow + $catAspan + $catBspan + $catCspan + $categoryDrow + 1)"/>
     </xsl:variable>
     <xsl:variable name="totalE">
       <xsl:value-of select="($headerrow + $headercatgoryrow + $catAspan + $catBspan + $catCspan + $catDspan + $categoryErow + 1)"/>
     </xsl:variable>
     
      <tr><td> </td></tr>
      <tr><td> </td></tr>
      <tr><td> </td></tr>
      <tr>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td colspan="2" class="contentNormalNoBorder" align="center">QUORUM COSTITUTIVO</td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td  colspan="2" class="contentNormalNoBorder" align="left">voti favorevoli</td>        
      </tr>
      <tr>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td> </td>
        <td class="totalPercBlu" align="right" x:fmla="M{$totalA}+M{$totalB}+M{$totalC}+M{$totalD}+M{$totalE}"></td>
        <td class="totalPercGreen" align="right" x:fmla="N{$totalA}+N{$totalB}+N{$totalC}+N{$totalD}+N{$totalE}"></td>
        <td> </td>
        <td> </td>
        <td class="totalPercBlu" align="right" x:fmla="Q{$totalA}+Q{$totalB}+Q{$totalC}+Q{$totalD}+Q{$totalE}"></td>
        <td class="totalPercGreen" align="right" x:fmla="R{$totalA}+R{$totalB}+R{$totalC}+R{$totalD}+R{$totalE}"></td>
      </tr>
      
   </xsl:if>

 </xsl:template>


<!-- ******************************************
           TEMPLATE ACTIVITY LIST
     ******************************************-->
<!--<xsl:template name="activitylist"
   xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet"
   xmlns="urn:schemas-microsoft-com:office:spreadsheet"
 >
 <xsl:param name="companykey"/>
 <xsl:param name="category"/>
 
 <div align="center">
   <xsl:for-each select="//report/section[@id='companylist']/row[@icompanykey = $companykey]">          
   <xsl:if test="($category = 'C') or ($category = 'D')">             
       --><!--<xsl:if test="(./@sschema ='A') or (./@sschema ='B')">--><!--
       <xsl:if test="(./@sschema != $category)">
         <xsl:if test="(./@principal = ./@sschema)">
           &#160;<strong><xsl:value-of select="./@sschema"/></strong>&#160;
         </xsl:if>
         <xsl:if test="(./@principal != ./@sschema)">
           &#160;<xsl:value-of select="./@sschema"/>&#160;
         </xsl:if>         
       </xsl:if>       
     </xsl:if>     

     <xsl:if test="($category != 'C') and ($category != 'D')">
       <xsl:if test="(./@sschema != $category)">
         <xsl:if test="(./@sschema = 'A') or (./@sschema ='E')">
           <xsl:if test="(./@principal = ./@sschema)">
             &#160;<strong><xsl:value-of select="./@sschema"/></strong>&#160;
           </xsl:if>
           <xsl:if test="(./@principal != ./@sschema)">
             &#160;<xsl:value-of select="./@sschema"/>&#160;
           </xsl:if>     
         </xsl:if>
         <xsl:if test="(./@sschema != 'A') and (./@sschema !='E')">
           <xsl:if test="(./@principal = ./@sschema)">
             &#160;<strong><xsl:value-of select="./@sschema"/></strong>&#160;
           </xsl:if>
           <xsl:if test="(./@principal != ./@sschema)">
             &#160;<xsl:value-of select="./@sschema"/>&#160;
           </xsl:if> 
         </xsl:if>         
       </xsl:if>
     </xsl:if>
   </xsl:for-each>
 </div>
</xsl:template>-->


</xsl:stylesheet>

