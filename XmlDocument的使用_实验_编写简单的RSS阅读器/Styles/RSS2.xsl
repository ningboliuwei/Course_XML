<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <xsl:apply-templates select="rss/channel" />
  </xsl:template>

  <xsl:template match="channel">
    <h2>
      <a href="{link}" target="_blank">
        <xsl:value-of select="title" />
      </a>
    </h2>
    <ul>
      <xsl:apply-templates select="item" />
    </ul>
  </xsl:template>

  <xsl:template match="item">

    <div style="background-color:#ccc"><li>
      <a href="{link}" target="_blank">
        <xsl:value-of select="title" />
      </a>
      - <xsl:value-of select="pubDate" />
      <br />
      <xsl:value-of disable-output-escaping="yes" select="description" />
      <p />
    </li>
    </div>
  </xsl:template>
</xsl:stylesheet>