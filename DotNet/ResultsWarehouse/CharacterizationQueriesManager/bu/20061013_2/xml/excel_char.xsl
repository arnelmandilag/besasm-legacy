<?xml version='1.0'?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0" xmlns:xslt="http://www.w3.org/TR/xslt">
  <xsl:template match="/">  	
		<HTML>
			<HEAD>
				<STYLE>
					.TABLENAME { font-family:arial; font-size:10pt; font-weight:bold; }
					.STUDYAREA { font-family:arial; font-size:10pt; }
					.COLUMNNAME { font-family:"arial narrow"; font-size:10pt; 
												vertical-align:bottom; border-top:thin solid black; 
												border-bottom:thin solid black; font-weight:bold;
												padding-left:5px; padding-right:5px; }
					.SUBCOLUMN { font-family:"arial narrow"; font-size:10pt; vertical-align:bottom; border-top:thin solid black; font-weight:bold }
					.ROWNAME { font-family:"arial narrow"; font-size:9pt; text-align:left; }
					.FUNCTION {font-family:"arial narrow"; font-size:9pt; vertical-align:middle; }
					.TOPBORDER { font-family:"arial narrow"; font-size:9pt; border-top:thin solid black; }					
					.FOOTER { font-family:"arial narrow"; font-size:9pt; }
					.TABLE { border-collapse:collapse; empty-cells:show; }
					.EMPHASIS { font-family:"arial narrow"; font-size:9pt; font-weight:bold; }
					.CONST { font-family:"arial narrow"; font-size:9pt; }
					THEAD {  display:table-header-group; }	
					TBODY { }
					TFOOT { }
															
				</STYLE>
			</HEAD>
					
			<BODY>
				<xsl:for-each select="StudyArea/CharacterizationTable"><p>							
					<xsl:variable name="COLCOUNT" select="@columnCount" />	
		    	<TABLE VALIGN="top" CLASS="TABLE" >
		    		<THEAD>		    					    				 												
							<TR>
								<TD CLASS="TABLENAME" COLSPAN="{$COLCOUNT}">
									Table <xsl:value-of select="@tableNumber" />. <xsl:value-of select="@tableTitle" />
								</TD>
							</TR>
							<TR>
								<TD CLASS="STUDYAREA" COLSPAN="{$COLCOUNT}">
									<xsl:value-of select="../@studyArea" /> Study Area
								</TD>
							</TR>
		    			<xsl:for-each select="Header">
		    				<TR>
		    					<xsl:for-each select="Cell">
			    					<xsl:variable name="CELLTYPE" select="@cellType" />
			    					<xsl:variable name="COLSPAN" select="@colSpan" />	
			    					<xsl:variable name="ROWSPAN" select="@rowSpan" />			    					
			    					<TD CLASS="{$CELLTYPE}" ALIGN="CENTER" COLSPAN="{$COLSPAN}" ROWSPAN="{$ROWSPAN}">		    							
	    								<xsl:value-of select="@data" /><SUP><xsl:value-of select="@footerID" /></SUP>
	    							</TD>		    							    					    								
			    				</xsl:for-each>		    				
		    				</TR>
		    			</xsl:for-each>
		    		</THEAD>		    	
		    		<TBODY>
			    		<xsl:for-each select="Row">		    			
								<TR>		    			
			    				<xsl:for-each select="Cell">
			    					<xsl:variable name="CELLTYPE" select="@cellType" />
			    					<xsl:variable name="COLSPAN" select="@colSpan" />	
			    					<xsl:variable name="ROWSPAN" select="@rowSpan" />			    					
			    					<TD CLASS="{$CELLTYPE}" ALIGN="CENTER" COLSPAN="{$COLSPAN}" ROWSPAN="{$ROWSPAN}">		    							
	    								<xsl:value-of select="@data" /><SUP><xsl:value-of select="@footerID" /></SUP>
	    							</TD>		    							    					    								
			    				</xsl:for-each> 		    	
			    			</TR>
			    		</xsl:for-each>    		
		    		</TBODY>
		    		<TFOOT>		    			   			
		    			<xsl:choose>
  							<xsl:when test="not(child::Footer)">
    							<TR><TD CLASS="TOPBORDER" COLSPAN="{$COLCOUNT}"></TD></TR>
  							</xsl:when>
  							<xsl:when test="child::Footer">
    							<xsl:for-each select="Footer">
    								<xsl:if test="preceding-sibling::Footer">
		    							<TR>		    							
			    							<TD CLASS="FOOTER" COLSPAN="{$COLCOUNT}">
			    								<SUP><xsl:value-of select="@footerID" /></SUP><xsl:value-of select="@footerText" />		    				
			    							</TD>
		  	  						</TR>
		  	  					</xsl:if>
    								<xsl:if test="not(preceding-sibling::Footer)">
		    							<TR>		    							
			    							<TD CLASS="TOPBORDER" COLSPAN="{$COLCOUNT}">
			    								<SUP><xsl:value-of select="@footerID" /></SUP><xsl:value-of select="@footerText" />		    				
			    							</TD>
		  	  						</TR>
		  	  					</xsl:if>		  	  					
		    					</xsl:for-each>
		  					</xsl:when>
							</xsl:choose>   		    			
		    		</TFOOT>  				    		
		    	</TABLE>				    		   		    	   		    		    	
		    	</p><br />	  			    	
		    </xsl:for-each>
		 	</BODY>
		</HTML>
  </xsl:template>
</xsl:stylesheet>
